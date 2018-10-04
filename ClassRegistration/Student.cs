/****************************************************
  Boobin Choi
  CIST 2342
  Lab #5,6
  Student Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Student: Person
    {
        //====================== PROPERTIES =====================
        public int Sid { set; get; }
        public double Gpa { set; get; }

        Address a1;

        //====================== CONSTRUCTORS =====================
        public Student():base()
        {
            Sid = 0;
            Gpa = 0.0;
        }// end default constructor
        
        public Student(int sid, string fn, string ln, string str, string c, string s, int z, string e, double gpa):base(fn, ln, str, c, s, z, e)
        {
            Sid = sid;
            Gpa = gpa;
        }//end Person constructor

        public Student(int sid)
        {
            SelectDB(sid);
        }

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
        public void SelectDB(int sid)
        {
            DBSetup();

            cmd = "SELECT * from Students where ID = " + sid;

            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;

            Console.WriteLine(cmd);

            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                Sid = sid;

                setFname(dr.GetValue(1) + "");
                setLname(dr.GetValue(2) + "");

                base.a1.setStreet(dr.GetValue(3) + "");
                base.a1.setCity(dr.GetValue(4) + "");
                base.a1.setState(dr.GetValue(5) + "");
                base.a1.setZip(Int32.Parse(dr.GetValue(6) + ""));

                setEmail(dr.GetValue(7) + "");
                Gpa = Double.Parse(dr.GetValue(8) + "");
                
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

            cmd = "INSERT into Students values(" + Sid + "," +
                                            "'" + getFname() + "'," +
                                            "'" + getLname() + "'," +
                                            "'" + base.a1.getStreet() + "'," +
                                            "'" + base.a1.getCity() + "'," +
                                            "'" + base.a1.getState() + "'," +
                                            + base.a1.getZip() + "," +
                                            "'" +getEmail() + "'," +
                                            Gpa + ")";

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
            cmd = "UPDATE Students set FirstName = '" + getFname() + "'," +
                                "LastName = '" + getLname() + "'," +
                                "Street = '" + base.a1.getStreet() + "'," +
                                "City = '" + base.a1.getCity() + "'," +
                                "State = '" + base.a1.getState() + "'," +
                                "Zip = " + base.a1.getZip() + "," +
                                "EMail = '" + getEmail() + "'," +
                                "GPA = " + Gpa +
                                " WHERE ID = " + Sid;

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
            cmd = "DELETE from Students where ID = " + Sid;
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
            Console.WriteLine("Student ID = " + Sid);
            base.display();
            Console.WriteLine("GPA = " + Gpa);

        }// end Display function
    }
}
