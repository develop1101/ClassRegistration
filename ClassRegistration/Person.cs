/****************************************************
  Boobin Choi
  CIST 2342
  Lab #4
  Person Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Person
    {
        //====================== PROPERTIES =====================
        private string Fname;
        private string Lname;
        private string Email;
        
        // add Address Object
        public Address a1 = new Address();

        // add Schedule Object
        public Schedule ss = new Schedule();

        //====================== CONSTRUCTOR =====================
        public Person()
        {
            Fname = "";
            Lname = "";
            Email = "";

        }// end default constructor
        
        public Person(string fn, string ln, string str, string c, string s, int z, string e)
        {
            Fname = fn;
            Lname = ln;
            Email = e;
            
            // add Address Object 
            a1 = new Address(str, c, s, z);

        }//end Person constructor

        //====================== BEHAVIORS =====================

        public string getFname() { return Fname; }
        public void setFname(string fn) { Fname = fn; }

        public string getLname() { return Lname; }
        public void setLname(string ln) { Lname = ln; }

        public string getEmail() { return Email; }
        public void setEmail(string e) { Email = e; }

        // Set method for Address Object 
        public void setAddress(Address a) { a1 = a; }

        // Get method for Address Object 
        public Address getAddress() { return a1; }

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("First Name = " + Fname);
            Console.WriteLine("Last Name = " + Lname);
            a1.display();

            Console.WriteLine("Email = " + Email);
            
            ss.display();

        }// end Display function

    }// end class

}// end namespace
