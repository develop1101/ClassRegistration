/****************************************************
  Boobin Choi
  Lab #3
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
        public string Address { set; get; }
        public string Email { set; get; }

        //====================== CONSTRUCTOR =====================
        public Person()
        {
            Fname = "";
            Lname = "";
            Address = "";
            Email = "";
        }// end default constructor

        public Person(string fn, string ln, string a, string e)
        {
            Fname = fn;
            Lname = ln;
            Address = a;
            Email = e;
        }//end Person constructor

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("First Name = " + Fname);
            Console.WriteLine("Last Name = " + Lname);
            Console.WriteLine("Address = " + Address);
            Console.WriteLine("Email = " + Email);

        }// end Display function

    }// end class

}// end namespace
