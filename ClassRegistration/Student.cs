﻿/****************************************************
  Boobin Choi
  CIST 2342
  Lab #4
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

        // modify Student Constructor for Address Object *** lab #4 ***
        public Student(int sid, string fn, string ln, string str, string c, string s, int z, string e, double gpa):base(fn, ln, str, c, s, z, e)
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
