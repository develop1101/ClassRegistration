/****************************************************
  Boobin Choi
  Lab #3
  Form
*****************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegistration
{
    public partial class Form1 : Form
    {

        //=============================== GLOBAL DATA =========================================
        // declare the Course Reference as Global variable
        Course c1;

        // declare the Section Reference as Global variable
        Section s1;

        // declare the Address Reference as Global variable
        Address a1;

        // declare the Student Reference as Global variable ### Lab 3 ###
        Student st1;
        // declare the Instructor Reference as Global variable ### Lab 3 ###
        Instructor i1;

        public Form1()
        {
            InitializeComponent();
        }

        //======================= BUTTON FOR TESTING COURSE CLASS =============================
        private void btnCourse_Click(object sender, EventArgs e)
        {
            // create the Course object and fill with data
            c1 = new Course("CIST2342", "C# Programming II", "second part of C#", 4);

            // print Course data
            c1.display();
        }

        //======================= BUTTON FOR TESTING SECTION CLASS =============================
        private void btnSection_Click(object sender, EventArgs e)
        {
            // create the Section object and fill with data
            s1 = new Section(12345, "CIST2342", "Tue 1:00pm-4:25pm", "F1125", 12);

            // print Section data
            s1.display();
        }

        //======================= BUTTON FOR TESTING ADDRESS CLASS =============================
        private void btnAddress_Click(object sender, EventArgs e)
        {
            // create the Address object and fill with data
            a1 = new Address("631 spanish oak dr", "Acworth", "GA", 30102);

            // print Address data
            a1.display();
        }

        //======================= BUTTON FOR TESTING STUDENT CLASS ======= LAB #3 ======================
        private void btnStudent_Click(object sender, EventArgs e)
        {
            // create the Student object and fill with data
            st1 = new Student(1, "Larry", "Jones", "CO", "larry@yahoo.com", 3.2);

            // print Student data
            st1.display();
        }

        //======================= BUTTON FOR TESTING INSTRUCTOR CLASS ======= LAB #3 ======================
        private void btnInstructor_Click(object sender, EventArgs e)
        {
            // create the Instructor object and fill with data
            i1 = new Instructor(1, "Frank", "Smith", "IL", "frank@yahoo.com", "B601");

            // print Instructor data
            i1.display();
        }
    }
}
