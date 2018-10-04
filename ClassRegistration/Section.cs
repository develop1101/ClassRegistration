/****************************************************
  Boobin Choi
  CIST 2342
  Lab #5,6
  Section Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Section
    {
        //====================== PROPERTIES =====================
        private int crn;
        private string courseID;
        private string dayNtime;
        private string room;
        private int instructorID;

        //====================== CONSTRUCTOR =====================
        public Section()
        {
            crn = 0;
            courseID = "";
            dayNtime = "";
            room = "";
            instructorID = 0;
        }

        public Section(int c, string cid, string dt, string r, int iid)
        {
            crn = c;
            courseID = cid;
            dayNtime = dt;
            room = r;
            instructorID = iid;
        }

        public Section(int c)
        {
            SelectDB(c);
        }

        //====================== BEHAVIORS =====================
        public int getCrn() { return crn; }
        public void setCrn(int c) { crn = c; }

        public string getCourseID() { return courseID; }
        public void setCourseID(string cid) { courseID = cid; }

        public string getDayNtime() { return dayNtime; }
        public void setDayNTime(string dt) { dayNtime = dt; }

        public string getRoom() { return room; }
        public void setRoom(string r) { room = r; }

        public int getInstructorID() { return instructorID; }
        public void setInstructorID(int iid) { instructorID = iid; }

        //**************** DATABASE Data Elements **************
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public string cmd;

        //***************** DBSetup Function**********************
        public void DBSetup()
        {
            // instantiates all the DB objects to access a DB
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

            // instantiates OleDbDataAdapter, which contains 4 objects
            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

            // Command object contains a Connection object and an SQL string object
            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=c:\\Users\\mimih\\Downloads\\CIST 2342\\Lab\\RegistrationMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";

            Console.WriteLine("Connected to SQL...");

        } // end DBSetup()

        //********************** SELECT ****************************
        public void SelectDB(int c)
        {
            DBSetup();

            cmd = "SELECT * from Sections where CRN =  " + c ;

            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;

            Console.WriteLine(cmd);

            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                crn = c;
                setCourseID(dr.GetValue(1) + "");
                setDayNTime(dr.GetValue(2) + "");
                setRoom(dr.GetValue(3) + "");
                setInstructorID(Int32.Parse(dr.GetValue(4) + ""));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        } // end SelectDB()

        //********************** INSERT ****************************
        public void InsertDB()
        {
            DBSetup();
            cmd = "INSERT into Sections values(" + getCrn() + "," + 
                                            "'" + getCourseID() + "'," +
                                            "'" + getDayNtime() + "'," +
                                            "'" + getRoom() + "'," +
                                            getInstructorID() + ")";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();

                if (n == 1)
                    Console.WriteLine("Data Inserted...");
                else
                    Console.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        } // end InsertDB()

        //********************** UPDATE ****************************
        public void UpdateDB()
        {
            cmd = "Update Sections set CourseID = '" + getCourseID() + "'," +
                                        "TimeDays = '" + getDayNtime() + "'," +
                                        "RoomNo = '" + getRoom() + "'," +
                                        "Instructor = " + getInstructorID() +
                                        " where CRN = " + getCrn();

            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();

                if (n == 1)
                    Console.WriteLine("Data Updated...");
                else
                    Console.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        } // end UpdateDB()

        //********************** DELETE ****************************
        public void DeleteDB()
        {
            cmd = "DELETE from Sections where CRN = " + getCrn();

            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1)
                    Console.WriteLine("Data Deleted");
                else
                    Console.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        } // end DeleteDB

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("CRN = " + getCrn());
            Console.WriteLine("Course ID = " + getCourseID());
            Console.WriteLine("Day and Time = " + getDayNtime());
            Console.WriteLine("Room = " + getRoom());
            Console.WriteLine("Instructor ID = " + getInstructorID());
        }

    }// end class
}
