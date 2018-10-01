/****************************************************
  Boobin Choi
  Lab #2
  Section Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Section
    {
        //====================== PROPERTIES =====================
        private int crn;
        private string courseID;
        private string dayNtime;
        private string room;
        private int instructorID;

        //====================== CONSTRUCTOR =====================
        public Section()
        {
            crn = 0;
            courseID = "";
            dayNtime = "";
            room = "";
            instructorID = 0;
        }

        public Section(int c, string cid, string dt, string r, int iid)
        {
            crn = c;
            courseID = cid;
            dayNtime = dt;
            room = r;
            instructorID = iid;
        }

        //====================== BEHAVIORS =====================
        public int getCrn() { return crn; }
        public void setCrn(int c) { crn = c; }

        public string getCourseID() { return courseID; }
        public void setCourseID(string cid) { courseID = cid; }

        public string getDayNtime() { return dayNtime; }
        public void setDayNTime(string dt) { dayNtime = dt; }

        public string getRoom() { return room; }
        public void setRoom(string r) { room = r; }

        public int getInstructorID() { return instructorID; }
        public void setInstructorID(int iid) { instructorID = iid; }

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("CRN = " + getCrn());
            Console.WriteLine("Course ID = " + getCourseID());
            Console.WriteLine("Day and Time = " + getDayNtime());
            Console.WriteLine("Room = " + getRoom());
            Console.WriteLine("Instructor ID = " + getInstructorID());
        }

    }// end class
}
