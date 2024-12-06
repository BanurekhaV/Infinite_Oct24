using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedADO
{
    class ProcedureCalls
    {
        static SqlConnection con;
        static SqlCommand cmd;

        public static void Main()
        {
            using (SqlConnection con = new SqlConnection("Server=Laptop-tjj7d977;initial catalog=infinitedb; integrated security=true;"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_getsalary",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ename", SqlDbType.VarChar, 20)).Value = "AdiSiva";

                    SqlParameter param = new SqlParameter("@salary", SqlDbType.Float);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);

                     cmd.ExecuteScalar();
                     int sal = Convert.ToInt32(cmd.Parameters["@salary"].Value);
                    Console.WriteLine("Salary : " + sal);

                }
            }
            Console.Read();
        }
    }
}
