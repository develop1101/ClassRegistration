/****************************************************
  Boobin Choi
  Lab #2
  Course Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Course
    {
        //====================== PROPERTIES =====================
        private string courseID;
        private string courseName;
        private string description;
        private int creditHour;

        //====================== CONSTRUCTOR =====================
        public Course()
        {
            courseID = "";
            courseName = "";
            description = "";
            creditHour = 0;
        }

        public Course(string cid, string cname, string des, int crh)
        {
            courseID = cid;
            courseName = cname;
            description = des;
            creditHour = crh;
        }

        //====================== BEHAVIORS =====================
        public string getCourseID() { return courseID; }
        public void setCourseID(string cid) { courseID = cid; }

        public string getCourseName() { return courseName; }
        public void setCourseName(string cname) { courseName = cname; }

        public string getDescription() { return description; }
        public void setDescription(string des) { description = des; }

        public int getCreditHour() { return creditHour; }
        public void setCreditHour(int crh) { creditHour = crh; }

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("Course ID = " + getCourseID());
            Console.WriteLine("Course Name = " + getCourseName());
            Console.WriteLine("Corse Description = " + getDescription());
            Console.WriteLine("Credit Hour = " + getCreditHour());
        }
    }
}
;