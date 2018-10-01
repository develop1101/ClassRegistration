/****************************************************
  Boobin Choi
  Lab #3
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

        //====================== CONSTRUCTORS =====================
        public Student():base()
        {
            Sid = 0;
            Gpa = 0.0;
        }// end default constructor

        public Student(int sid, string fn, string ln, string a, string e, double gpa):base(fn, ln, a, e)
        {
            Sid = sid;
            Gpa = gpa;
        }//end Person constructor

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("Student ID = " + Sid);
            base.display();
            Console.WriteLine("GPA = " + Gpa);

        }// end Display function
    }
}
