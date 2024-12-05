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
        internal void InsertRegion()
        {
            Console.WriteLine("Enter The Region ID :");
            RegionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Region Description :");
            RegionDescription = Console.ReadLine();
            da.InsertRegion(RegionID, RegionDescription);
        }

        internal void SelectRegions()
        {
            da.SelectData();
        }
    }

    class DataAccess
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;

        public SqlConnection getConnection()
        {
            string connectstr = "Data Source=Laptop-tjj7d977;Initial Catalog=Northwind;" +
                "Integrated Security=true;";
            conn = new SqlConnection(connectstr);
            conn.Open();
            return conn;
        }

        public void SelectData()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("Select * from Region", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while(dr.Read())
                {
                    Console.WriteLine(dr["RegionID"] + " " + dr["RegionDescription"]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertRegion(int rid, string rdesc)
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("insert into region values(@rgid,@rgdesc)", conn);
                cmd.Parameters.AddWithValue("@rgid", rid);
                cmd.Parameters.AddWithValue("@rgdesc", rdesc);
                cmd.ExecuteNonQuery();                
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
    class Ado2
    {
        public static void Main()
        {
            Region region = new Region();
            region.SelectRegions();
            Console.WriteLine();
            region.InsertRegion();
            Console.WriteLine();
            region.SelectRegions();
            Console.Read();
        }
    }
}
