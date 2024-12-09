using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Xml;

namespace XMLOperations
{
    class Program
    {
        static DataSet ds = new DataSet("DS");
        static void Main(string[] args)
        {
          //  XmlWriter();
            Console.WriteLine("--------Xml Data---------");
           // XmlReader();
            Console.WriteLine("----Xml Schema Data -------");
            XmlSchemaWriter();
            XmlSchemaReader();
            Console.Read();
        }

       static void  creatingContent()
        {
            ds.Namespace = "StdNameSpace";
            DataTable stdTable = new DataTable("Student");

            DataColumn col1 = new DataColumn("Name");
            DataColumn col2 = new DataColumn("Address");

            stdTable.Columns.Add(col1);
            stdTable.Columns.Add(col2);

            ds.Tables.Add(stdTable);

            DataRow dr = stdTable.NewRow();
            dr["Name"] = "Bhavani";
            dr["Address"] = "Vizag";

            stdTable.Rows.Add(dr);

            dr = stdTable.NewRow();
            dr["Name"] = "Ramya";
            dr["Address"] = "Vizag";

            stdTable.Rows.Add(dr);

            dr = stdTable.NewRow();
            dr["Name"] = "Suchitha";
            dr["Address"] = "Blore";

            stdTable.Rows.Add(dr);

            ds.AcceptChanges();  //this commits the changes made to the dataset
        }
        static void XmlWriter()
        {
            try
            {
                creatingContent();
                //create streamwriter object the dataset data

                StreamWriter sw = new StreamWriter("Student.xml");

                ds.WriteXml(sw);  //dataset data is being written to an xml file
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void XmlReader()
        {
            DataSet ds1 = new DataSet();

            ds1.ReadXml("Student.xml");  //fills the dataset with the data

            foreach(DataTable dt in ds1.Tables)
            {
                Console.WriteLine(dt);
                for(int i=0; i<dt.Columns.Count;i++)
                {
                    Console.Write("\t" + "\t" + dt.Columns[i].ColumnName);
                }
                Console.WriteLine();
                foreach(DataRow r in dt.Rows)
                {
                    for(int j= 0; j<dt.Columns.Count;j++)
                    {
                        Console.Write("\t" + "\t"  + r[j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------------");
                foreach(var row in dt.AsEnumerable())
                {
                    for(int j =0; j<dt.Columns.Count;j++)
                    {
                        Console.Write("\t" + "\t" + row[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void XmlSchemaWriter()
        {
            creatingContent();
            ds.WriteXmlSchema("StudentSchema");
        }

        static void XmlSchemaReader()
        {
            ds = new DataSet("SchemaSet");
            StreamReader sr = new StreamReader("StudentSchema");
            ds.ReadXmlSchema(sr); //iterate the data

            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(writer);
        }
    }
}
