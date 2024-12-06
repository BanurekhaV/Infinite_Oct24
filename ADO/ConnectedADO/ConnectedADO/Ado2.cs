using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedADO
{
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        DataAccess da = new DataAccess();
        internal int InsertRegion()
        {
            Console.WriteLine("Enter The Region ID :");
            RegionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Region Description :");
            RegionDescription = Console.ReadLine();
            int res=da.InsertRegion(RegionID, RegionDescription);
            return res;
        }

        internal SqlDataReader SelectRegions()
        {
            SqlDataReader dr1 = da.SelectData();
            return dr1;
        }

        public void CallProc()
        {
            da.CallProc();
        }

        public void GetRegionCount()
        {
            da.GetRegionCount();
        }

        public void ProcWithParameter()
        {
            da.ProcWithParameter();
        }
    }

    class DataAccess
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;
        static int res;
        static SqlDataReader dr;

        public SqlConnection getConnection()
        {
            string connectstr = "Data Source=Laptop-tjj7d977;Initial Catalog=Northwind;" +
                "Integrated Security=true;";
            conn = new SqlConnection(connectstr);
            conn.Open();
            return conn;
        }

        public SqlDataReader SelectData()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("Select * from Region", conn);
                dr = cmd.ExecuteReader();
           
               // return dr;

                //while (dr.Read())
                //{
                //    Console.WriteLine(dr["RegionID"] + " " + dr["RegionDescription"]);
                //}
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            //finally
            //{

            //    //conn.Close();
            //}
            return dr;
        }

        public int InsertRegion(int rid, string rdesc)
        {             
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("insert into region values(@rgid,@rgdesc)", conn);
                cmd.Parameters.AddWithValue("@rgid", rid);
                cmd.Parameters.AddWithValue("@rgdesc", rdesc);
                res=cmd.ExecuteNonQuery();
                return res;
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            return res;
        }

        public void CallProc()
        {
            conn = getConnection();
            cmd = new SqlCommand("Ten Most Expensive Products", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //execute scalar will ignore all values except for the first value(0,0)
            //object o = cmd.ExecuteScalar().ToString();
            //Console.WriteLine(o);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + "  " + dr[1]);
            }
        }

        //executing function that return scalar data
        public void GetRegionCount()
        {
            conn = getConnection();
            cmd = new SqlCommand("select count(regionid) from region", conn);
            int count=Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("No of Regions Available is {0}",count);
        }

        public void ProcWithParameter()
        {
            conn = getConnection();
            Console.WriteLine("Enter The Customer ID :");
            string custid = Console.ReadLine();
            cmd = new SqlCommand("custordersorders", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //option 1 to attach parameter values 
            //cmd.Parameters.AddWithValue("@customerid", custid);

            //option 2
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@customerid";
            param1.Value = custid;
            param1.DbType = DbType.String;
            param1.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(param1);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                Console.WriteLine(sdr["OrderId"] + " " + sdr["OrderDate"] + " " + sdr["ShippedDate"]);
            }
        }
    }
    class Ado2
    {
        public static void Main()
        {
            Region region = new Region();
            Console.WriteLine();
            //int res = region.InsertRegion();
            //if (res > 0)
            //    Console.WriteLine("Record Successfully");
            //else
            //    Console.WriteLine("Failed to Insert");
            Console.WriteLine();
            SqlDataReader dr2 = region.SelectRegions();
            while(dr2.Read())
            {                
                    Console.WriteLine($"The Region Id is {dr2["RegionID"] } and the Description is {dr2["RegionDescription"]}");                
            }
            Console.WriteLine("--------Calling Procedure with no Input/OutPut-------");
            region.CallProc();
            Console.WriteLine("---------Region Count----------");
            region.GetRegionCount();
            Console.WriteLine("-----Procedure with Parameter-------");
            region.ProcWithParameter();
             Console.Read();
        }
    }
}
