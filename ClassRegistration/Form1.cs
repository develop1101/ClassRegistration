/****************************************************
  Boobin Choi
  CIST 2342
  Lab #4
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
       // Section s1;

        // declare the Address Reference as Global variable
        Address a1;

        // declare the Student Reference as Global variable ### Lab 4 ###
        Student st1;
        // declare the Instructor Reference as Global variable ### Lab 4 ###
        Instructor i1;
        // declare the Schedule Reference as Global variable ### Lab 4 ###
        Schedule ss;
        // declare the Person Reference as Global variable ### Lab 4 ###
        Person p1;

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

        //======================= BUTTON FOR TESTING SECTION CLASS ====== LAB #4 =======================
        private void btnSection_Click(object sender, EventArgs e)
        {
            // create the Section object and fill with data
            // s1 = new Section(12345, "CIST2342", "Tue 1:00pm-4:25pm", "F1125", 12);

            // instantiate a schedule *** Lab #4 ***
            ss = new Schedule();

            // add 2 sections to the Schedule *** Lab #4 ***
            ss.addSection(new Section(20383, "CIST2342", "Tue 1:00pm-4:25pm", "F1125", 4));
            ss.addSection(new Section(20395, "CIST2931", "Wed 1:00pm-4:25pm", "F1125", 4));

            // print Section data *** Lab #4 ***
            ss.display();
        }

        //======================= BUTTON FOR TESTING ADDRESS CLASS =============================
        private void btnAddress_Click(object sender, EventArgs e)
        {
            // create the Address object and fill with data
            a1 = new Address("631 spanish oak dr", "Acworth", "GA", 30102);

            // print Address data
            a1.display();
        }

        //======================= BUTTON FOR TESTING STUDENT CLASS ======= LAB #4 ======================
        private void btnStudent_Click(object sender, EventArgs e)
        {
            // create the Student object and fill with data
            st1 = new Student(1, "Larry", "Jones", "123 Main St.", "Dallas", "TX", 50116, "larry@yahoo.com", 3.2);

            // add 2 sections to the Schedule *** Lab #4 ***
            st1.ss.addSection(new Section(20383, "CIST2342", "Tue 1:00pm-4:25pm", "F1125", 4));
            st1.ss.addSection(new Section(20395, "CIST2931", "Wed 1:00pm-4:25pm", "F1125", 4));

            // print Student data
            st1.display();
        }

        //======================= BUTTON FOR TESTING INSTRUCTOR CLASS ======= LAB #4 ======================
        private void btnInstructor_Click(object sender, EventArgs e)
        {
            // create the Instructor object and fill with data
            i1 = new Instructor(1, "Frank", "Smith", "124 street", "Atlanta", "GA", 30102, "frank@yahoo.com", "B601");

            // print Instructor data
            i1.display();
        }

        //======================= BUTTON FOR TESTING INSTRUCTOR CLASS ======= LAB #4 ======================
        private void btnPerson_Click(object sender, EventArgs e)
        {
            // create the Instructor object and fill with data
            p1 = new Person("David", "Martin", "123 rd", "Kennesaw", "GA", 30101, "david@yahoo.com");

            // add 2 sections to the Schedule to the Person *** Lab #4 ***
            p1.ss.addSection(new Section(20383, "CIST2342", "Tue 1:00pm-4:25pm", "F1125", 4));
            p1.ss.addSection(new Section(20395, "CIST2931", "Wed 1:00pm-4:25pm", "F1125", 4));

            // print Person data
            p1.display();
        }
    }
}
