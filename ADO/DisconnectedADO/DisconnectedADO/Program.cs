using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedADO
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter da = null;
        static void Main(string[] args)
        {
            //  Disconnected_approach();
            AddRegion_with_Adapter();
            Console.Read();
        }

        public static void Disconnected_approach()
        {
            con = new SqlConnection("Data Source=Laptop-tjj7d977;database=northwind;trusted_connection=true;");
            con.Open();
            da = new SqlDataAdapter("select * from region", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "NorthwindRegion");
            DataTable dt = ds.Tables["NorthwindRegion"]; //this points to beginning of the datatable

            //to access the rows and columns from the data table
            foreach(DataRow drow in dt.Rows)
            {
                foreach(DataColumn dcol in dt.Columns)
                {
                    Console.Write(drow[dcol]);
                    Console.WriteLine();
                }
            }

            //adding one more table to the dataset
            Console.WriteLine("**************************");
            da = new SqlDataAdapter("select * from shippers", con);
            da.Fill(ds, "NorthwindShippers");
            dt = ds.Tables["NorthwindShippers"];

            foreach (DataRow drow in dt.Rows)
            {
                foreach (DataColumn dcol in dt.Columns)
                {
                    Console.Write(drow[dcol]);
                    Console.WriteLine();
                }
            }

            da = new SqlDataAdapter("[ten most expensive products]", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(ds, "ExpensiveProducts");
            dt = ds.Tables["ExpensiveProducts"];
            Console.WriteLine("***********************");
            foreach (DataRow drow in dt.Rows)
            {
                foreach (DataColumn dcol in dt.Columns)
                {
                    Console.Write(drow[dcol]);
                    Console.WriteLine();
                }
            }
        }

        public static void AddRegion_with_Adapter()
        {
            try
            {
                con = new SqlConnection("Data Source=Laptop-tjj7d977;database=northwind;trusted_connection=true;");
                con.Open();
                da = new SqlDataAdapter("select * from region", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "NRegion");

                DataTable dt = ds.Tables["NRegion"];
                Console.WriteLine("------Data as is ------");

                foreach (DataRow drow in dt.Rows)
                {
                    foreach (DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.WriteLine();
                    }
                }
                //let us now add onr row in the datatable to accomodate a new record
                DataRow row = ds.Tables["NRegion"].NewRow();

                //let us give values to the columns in the new row
                row["RegionId"] = 200;
                row["RegionDescription"] = "Cyclonic Region";

                //now add the new row with data to the rows collection of the datatable

                ds.Tables["NRegion"].Rows.Add(row);

                SqlCommandBuilder scb = new SqlCommandBuilder(da);

                da.InsertCommand = scb.GetInsertCommand();

                da.Update(ds, "NRegion");

                Console.WriteLine("----------Post Insertion-----------");
                da.Fill(ds);  //to refresh the dataset after changes made to the database

                dt = ds.Tables["NRegion"];

                foreach (DataRow drow in dt.Rows)
                {
                    foreach (DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.WriteLine();
                    }
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Duplicate Region ID is being inserted");
            }

        }
    }
}
