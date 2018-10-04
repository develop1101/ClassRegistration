/****************************************************
  Boobin Choi
  CIST 2342
  Lab #5, 6
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
        
        public Form1()
        {
            InitializeComponent();
        }

        // Global variable for Address object to get the address values of Student & Instructor
        Address address;

        //======================= BUTTON FOR TESTING COURSE CLASS =============================
        private void btnCourse_Click(object sender, EventArgs e)
        {
            //********** Testing SelectDB() ************** 
            /*
            Course c1;
            c1 = new Course();
            c1.SelectDB("CIST 1001");
            c1.display();
            */

            //********** Testing InsertDB() ****************
            /*
            Course c2;
            c2 = new Course("CIST 1313", "Python I", "Intro to Python", 3);
            c2.InsertDB();
            */

            //********** Testing UpdateDB() *****************
            /*
            Course c3;
            c3 = new Course("CIST 1313");
            c3.SelectDB("CIST 1313");
            c3.setCourseName("Python II");
            c3.setDescription("Advanced Python");
            c3.setCreditHour(4);
            c3.UpdateDB();
            */

            //********** Testing DeleteDB() *******************
            Course c4;
            c4 = new Course();
            c4.SelectDB("CIST 1313");
            c4.DeleteDB();
            

        }

        //======================= BUTTON FOR TESTING SECTION CLASS =============================
        private void btnSection_Click(object sender, EventArgs e)
        {
            //************ Testing SelectDB()********************
            /*
            Section s1;
            s1 = new Section();
            s1.SelectDB(30101);
            s1.display();
            */

            //*************** Testing InsertDB() *****************
            /*
            Section s2;
            s2 = new Section(31111, "CIST 1313", "MW1-5pm", "F1111", 3);
            s2.InsertDB();
            */

            //*************** Testing UpdateDB() *****************
            /*
            Section s3;
            s3 = new Section(31111);
            s3.SelectDB(31111);
            s3.setCourseID("CIST 1313");
            s3.setDayNTime("TTh1-5pm");
            s3.setRoom("F1313");
            s3.setInstructorID(5);
            s3.UpdateDB();
            */

            //*************** Testing DeleteDB() *****************
            Section s4;
            s4 = new Section();
            s4.SelectDB(31111);
            s4.DeleteDB();
            
        }

        

        //======================= BUTTON FOR TESTING STUDENT CLASS =============================
        private void btnStudent_Click(object sender, EventArgs e)
        {
            //************ Testing SelectDB()******************** 
            /*
            Student st1;
            st1 = new Student();
            st1.SelectDB(1);
            st1.display();
            */

            //*************** Testing InsertDB() *****************
            /*
            Student st2;
            st2 = new Student(20, "Michelle", "Choi", "631 Spanish Oak Dr.", "Acworth", "GA", 30102, "michelle@gmail.com", 4.0);
            st2.InsertDB();
            */

            //*************** Testing UpdateDB() *****************
            /*
            Student st3;
            st3 = new Student(20);
            st3.SelectDB(20);
            st3.setFname("Katie");
            st3.setLname("Chang");
            address = new Address("600 main rd", "Atlanta", "GA", 30102);
            st3.setAddress(address);
            st3.setEmail("katie@gmail.com");
            st3.Gpa = 4.0;
            st3.UpdateDB();
            */

            //*************** Testing DeleteDB() *****************
            
            Student st4;
            st4 = new Student();
            st4.SelectDB(20);
            st4.DeleteDB();
            
        }

        //======================= BUTTON FOR TESTING INSTRUCTOR CLASS =============================
        private void btnInstructor_Click(object sender, EventArgs e)
        {
            //************ Testing SelectDB()********************
            /*
            Instructor i1;
            i1 = new Instructor();
            i1.SelectDB(1);
            i1.display();
            */

            //*************** Testing InsertDB() *****************
            /*
            Instructor i2;
            i2 = new Instructor(10, "Michelle", "Choi", "631 Spanish Oak dr.", "Acworth", "GA", 30102, "A1111", "michelle@gmail.com");
            i2.InsertDB();
            */

            //*************** Testing UpdateDB() *****************
            /*
            Instructor i3;
            i3 = new Instructor(10);
            i3.SelectDB(10);
            i3.setFname("Lena");
            i3.setLname("Chang");
            address = new Address("100 main st.", "Atlanta", "GA", 30002);
            i3.setAddress(address);
            i3.Office = "A1014";
            i3.setEmail("lena@yahoo.com");
            i3.UpdateDB();
            */

            //*************** Testing DeleteDB() *****************
            
            Instructor i4;
            i4 = new Instructor(10);
            i4.DeleteDB();
            

        }

        //======================= BUTTON FOR TESTING PERSON CLASS =============================
        private void btnPerson_Click(object sender, EventArgs e)
        {
            Person p1;
            
            // create the Instructor object and fill with data
            p1 = new Person("David", "Martin", "123 rd", "Kennesaw", "GA", 30101, "david@yahoo.com");
            // add 2 sections to the Schedule to the Person 
            p1.ss.addSection(new Section(20383, "CIST2342", "Tue 1:00pm-4:25pm", "F1125", 4));
            p1.ss.addSection(new Section(20395, "CIST2931", "Wed 1:00pm-4:25pm", "F1125", 4));
            
            // print Person data
            //p1.display();
        }

        //======================= BUTTON FOR TESTING ADDRESS CLASS =============================
        private void btnAddress_Click(object sender, EventArgs e)
        {
            Address a1;

            // create the Address object and fill with data
            a1 = new Address("631 spanish oak dr", "Acworth", "GA", 30102);

            // print Address data
            a1.display();
        }
    }
}
