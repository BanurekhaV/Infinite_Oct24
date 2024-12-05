using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedADO
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static IDataReader dr;
        static void Main()
        {
            // InsertData();
            DeleteData();
            SelectData();
            Console.Read();
        }

        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=Laptop-tjj7d977;Initial Catalog=InfiniteDB;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }
        static void SelectData()
        {
            con = getConnection();
            cmd = new SqlCommand("select * from tblemployee");
            cmd.Connection = con;
            dr=cmd.ExecuteReader();

            while(dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " +dr[2] + " " +dr[3] + " "+dr[4]);

                //Console.WriteLine("Employee ID :" + dr[0]);
                //Console.WriteLine("Employee Name :" + dr[1]);
                //Console.WriteLine("Employee Salary :" + dr[3]);
            }
            
        }

        static void InsertData()
        {
            con = getConnection();
            Console.WriteLine("Enter Empid, EmpName, Gender,Salary,Dept,Phone :");
            int eid = Convert.ToInt32(Console.ReadLine());
            string ename = Console.ReadLine();
            string egen = Console.ReadLine();
            float esal = Convert.ToSingle(Console.ReadLine());
            int edept = Convert.ToInt32(Console.ReadLine());
            string ephone = Console.ReadLine();
            //  cmd=new SqlCommand("Insert into tblemployee values(150,'Rama','Male',15000,5,0000007)",con);

            cmd = new SqlCommand("Insert into tblemployee values(@ecode,@empname,@egender@esalary,@edid,@eph)", con);
            //all the above variables are now appended to the parameters collection of the command object
            cmd.Parameters.AddWithValue("@ecode", eid);
            cmd.Parameters.AddWithValue("@empname", ename);
            cmd.Parameters.AddWithValue("@egender", egen);
            cmd.Parameters.AddWithValue("@esalary", esal);
            cmd.Parameters.AddWithValue("@edid", edept);
            cmd.Parameters.AddWithValue("@eph", ephone);

            int res = cmd.ExecuteNonQuery();
            if(res>0)
                Console.WriteLine("Inserted Successfully");
            else
                Console.WriteLine("Could not Insert..");
        }

        static void DeleteData()
        {
            con = getConnection();
            Console.WriteLine("Enter Empid to delete :");
            string eid = Console.ReadLine();
            SqlCommand cmd1 = new SqlCommand("select * from tblemployee where empid=@eid");
            cmd1.Connection = con;
            cmd1.Parameters.AddWithValue("@eid", eid);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while(dr1.Read())
            {
                for(int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine();
            Console.WriteLine("Are You sure to delete this Employee ( Y/N )? :");
            string answer = Console.ReadLine();
            if(answer=="Y" || answer=="y")
            {
                cmd = new SqlCommand("delete from tblemployee where empid=@eid", con);
                cmd.Parameters.AddWithValue("@eid", eid);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully..");
            }
        }
    }
}
    