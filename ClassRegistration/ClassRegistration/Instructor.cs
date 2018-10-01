/****************************************************
  Boobin Choi
  Lab #3
  Instructor Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Instructor: Person
    {
        //====================== PROPERTIES =====================
        public int Id { set; get; }
        public string Office { set; get; }

        //====================== CONSTRUCTORS =====================
        public Instructor() : base()
        {
            Id = 0;
            Office = "";
        }// end default constructor

        public Instructor(int id, string fn, string ln, string a, string e, string o) : base(fn, ln, a, e)
        {
            Id = id;
            Office = o;
        }//end Person constructor

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("Instructor ID = " + Id);
            base.display();
            Console.WriteLine("Office = " + Office);

        }// end Display function
    }
}
