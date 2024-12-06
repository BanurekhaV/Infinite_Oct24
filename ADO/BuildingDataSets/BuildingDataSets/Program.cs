using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BuildingDataSets
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. let us create an in-memory cache

            DataSet dsEmployement = new DataSet("Employement");

            //2. now add data table 1
            DataTable dtEmployees = new DataTable("Employees");

            //3. define columns to the table
            DataColumn[] dcEmployees = new DataColumn[4];

            //4. add column details in terms ofname, type,size etc
            dcEmployees[0] = new DataColumn("EmpCode", System.Type.GetType("System.Int32"));
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.String"));
            dcEmployees[2] = new DataColumn("EmpDept", System.Type.GetType("System.String"));
            dcEmployees[3] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));

            //5. Add the above columns to the data table
            dtEmployees.Columns.Add(dcEmployees[0]);
            dtEmployees.Columns.Add(dcEmployees[1]);
            dtEmployees.Columns.Add(dcEmployees[2]);
            dtEmployees.Columns.Add(dcEmployees[3]);

            //6. Now add rows with data
            DataRow drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "1";
            drEmpRows["EmpName"] = "Renuka";
            drEmpRows["EmpDept"] = "IT";
            drEmpRows["EmpStatusID"] = "1";

            //7. add the above to the data table
            dtEmployees.Rows.Add(drEmpRows);

            //repeat step 6 and 7 for no.of rows

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "2";
            drEmpRows["EmpName"] = "Rajesh";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";

           
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "3";
            drEmpRows["EmpName"] = "Somasekhar";
            drEmpRows["EmpDept"] = "Accounts";
            drEmpRows["EmpStatusID"] = "1";

          
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "4";
            drEmpRows["EmpName"] = "Sai Naga";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";

            
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "5";
            drEmpRows["EmpName"] = "Durga Sai";
            drEmpRows["EmpDept"] = "Operations";
            drEmpRows["EmpStatusID"] = "4";

          
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "6";
            drEmpRows["EmpName"] = "Poormitha";
            drEmpRows["EmpDept"] = "Admin";
            drEmpRows["EmpStatusID"] = "4";

           
            dtEmployees.Rows.Add(drEmpRows);

            //8. create another table
            DataTable dtEmpStatus = new DataTable("EmployeeStatus");
            //9. create columns for the 2nd table
            DataColumn[] dcStatus = new DataColumn[2];
            dcStatus[0] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));
            dcStatus[1] = new DataColumn("EmpStatus", System.Type.GetType("System.String"));

            //10 add columns to the table
            dtEmpStatus.Columns.Add(dcStatus[0]);
            dtEmpStatus.Columns.Add(dcStatus[1]);

            //11. rows for the table
            DataRow drStatusRow = dtEmpStatus.NewRow();

            //12. give values
            drStatusRow["EmpStatusID"] = "1";
            drStatusRow["EmpStatus"] = "Full Time";

            dtEmpStatus.Rows.Add(drStatusRow);

            drStatusRow = dtEmpStatus.NewRow();

            drStatusRow["EmpStatusID"] = "2";
            drStatusRow["EmpStatus"] = "Part Time";

            dtEmpStatus.Rows.Add(drStatusRow);

            drStatusRow = dtEmpStatus.NewRow();

            drStatusRow["EmpStatusID"] = "3";
            drStatusRow["EmpStatus"] = "Contract";

            dtEmpStatus.Rows.Add(drStatusRow);

            drStatusRow = dtEmpStatus.NewRow();

             drStatusRow["EmpStatusID"] = "4";
            drStatusRow["EmpStatus"] = "Interns";

            dtEmpStatus.Rows.Add(drStatusRow);

            //13. add the 2 tables to the dataset
            dsEmployement.Tables.Add(dtEmployees);
            dsEmployement.Tables.Add(dtEmpStatus);

            //14. associating 2 tables
            //14.1 primary and foreign key

            DataColumn parent = dsEmployement.Tables["EmployeeStatus"].Columns["EmpStatusID"];
            DataColumn child = dsEmployement.Tables["Employees"].Columns["EmpStatusID"];

            //14.2 set the relation
            DataRelation emprel1 = new DataRelation("EmpStatusRelation", parent, child);

            //14.3 adding the datarelation to the dataset
            dsEmployement.Relations.Add(emprel1);

            //15. now let us display data as per the relation

            Console.WriteLine("=============================================================");
            Console.WriteLine("Status ID           |            Employee Status          ");
            Console.WriteLine("-------------------------------------------------------------");

            foreach(DataRow row in dsEmployement.Tables["EmployeeStatus"].Rows)
            
                Console.WriteLine("{0}               |                {1}", row["EmpStatusID"], row["EmpStatus"]);

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("EmpCode  \t      |        Empname\t        +       Department\t            |          Status");
            Console.WriteLine("---------------------------------------------------------------------------");

            foreach(DataRow row in dsEmployement.Tables["Employees"].Rows)
            {
                //Console.WriteLine("{0}      \t       |       {1}  \t        |        {2}     \t          |          {3}", row["Empcode"],
                //    row["EmpName"], row["EmpDept"], row["EmpStatusID"]);

                //for getting the status as a string info, we can code as below
                int irow = int.Parse(row["EmpStatusID"].ToString());

                DataRow currentrow = dsEmployement.Tables["EmployeeStatus"].Rows[irow - 1];
                Console.WriteLine("{0}      \t       |       {1}  \t           |          {2}     \t          |          {3}", row["Empcode"],
                 row["EmpName"], row["EmpDept"], currentrow["EmpStatus"]);
            }

            Console.Read();
        }
    }

    }

    
