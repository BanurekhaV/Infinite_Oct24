using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Transactions;

namespace DisconnectedADO
{
    class ConnectionPooling
    {
        public static string connectstr = "Data Source=Laptop-tjj7d977;database=northwind;trusted_connection=true;Pooling=true";

        public static void Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i=0; i<1000;i++)
            {
                SqlConnection con = new SqlConnection(connectstr);
                con.Open();
                con.Close();
            }
            stopwatch.Stop();
            Console.WriteLine($"Time Taken : {stopwatch.ElapsedMilliseconds} ms");
            // Transaction_Eg(connectstr);
            TransactionScope_Eg(connectstr);
            Console.Read();
        }

        //transaction example
        public static void Transaction_Eg(string str)
        {
            using(SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand(); // an sql command object is created and returned

                //for transaction
                SqlTransaction tran;
                tran = con.BeginTransaction(); //associating a transaction object to the connection

                cmd.Transaction = tran;
                try
                {
                    cmd.CommandText = "Insert into Region values(150,'Infinite Zone')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Update Region set regiondescription='Monsoon Region' " +
                        "where regionid=200";
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                    Console.WriteLine("Transaction Completed...");
                }
                catch(SqlException se)
                {
                    Console.WriteLine("OOPS !! somethig went wrong..");                    
                    try
                    {
                        tran.Rollback();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        public static void TransactionScope_Eg(string str)
        {
            TransactionOptions options = new TransactionOptions();
            options.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            using(TransactionScope ts = new TransactionScope())
            {
                using(SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("insert into region values(160,'Some Region')",con))
                    {
                        int rowsupdated = cmd.ExecuteNonQuery();
                        if(rowsupdated >0)
                        {
                            using(SqlConnection con1 = new SqlConnection(str))
                            {
                                con1.Open();
                                using(SqlCommand cmd1 = new SqlCommand("insert into shippers values('Fedex','(100)-12345')",con1))
                                {
                                    int norows = cmd1.ExecuteNonQuery();
                                    if(norows>0)
                                    {
                                        ts.Complete();
                                        Console.WriteLine("Transaction Completed..");
                                        con1.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("TransactionFailed");
                            ts.Dispose();
                        }
                    }
                    con.Close();
                }
            }
        }
    }
}
