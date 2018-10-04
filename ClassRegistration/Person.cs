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
        public string Fname { set; get; }
        public string Lname { set; get; }
        // delete string Address Property
        //public string Address { set; get; }
        public string Email { set; get; }

        // add Address Object *** lab #4 ***
        private Address a1 = new Address();

        // add Schedule Object *** lab #4 ***
        public Schedule ss = new Schedule();

        //====================== CONSTRUCTOR =====================
        public Person()
        {
            Fname = "";
            Lname = "";
            // delete String Address
            //Address = "";
            Email = "";
        }// end default constructor

        // modify the constructor for Address Object *** lab #4 ***
        public Person(string fn, string ln, string str, string c, string s, int z, string e)
        {
            Fname = fn;
            Lname = ln;
            // delete String Address
            // Address = a;
            Email = e;
            
            // add Address Object *** lab #4 ***
            a1 = new Address(str, c, s, z);

        }//end Person constructor

        // Set method for Address Object *** lab #4 ***
        public void setAddress(Address a) { a1 = a; }

        // Get method for Address Object *** lab #4 ***
        public Address getAddress() { return a1; }

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("First Name = " + Fname);
            Console.WriteLine("Last Name = " + Lname);
            //Console.WriteLine("Address = " + Address);
            
            // add display for Address Object *** lab #4 ***
            a1.display();

            Console.WriteLine("Email = " + Email);
            Console.WriteLine("Sections that you added...");

            // add display for Scheduled Section *** lab #4 ***
            ss.display();

        }// end Display function

    }// end class

}// end namespace
