using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using context = System.Web.HttpContext;

namespace Exception_Prj
{
    public static class ExceptionLogging
    {
        static string exurl;
        static SqlConnection con;

        private static void getConnection()
        {
            con = new SqlConnection("Data Source=Laptop-tjj7d977; initial catalog=infinitedb;" +
                "integrated security=true;");
            con.Open();
        }

        public static void LogExceptionToDB(Exception exdb)
        {
            getConnection();
            exurl = context.Current.Request.Url.ToString();
            SqlCommand cmd = new SqlCommand("ExceptionLoggingToDatabase", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //add all the parameters to the command objects parameter collection
            cmd.Parameters.AddWithValue("@exceptionmsg", exdb.Message.ToString());
            cmd.Parameters.AddWithValue("@exceptiontype", exdb.GetType().Name.ToString());
            cmd.Parameters.AddWithValue("@exceptionsource", exdb.StackTrace.ToString());
            cmd.Parameters.AddWithValue("@exceptionurl", exurl);

            cmd.ExecuteNonQuery();
        }
    }
}