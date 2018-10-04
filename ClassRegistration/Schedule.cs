/****************************************************
  Boobin Choi
  CIST 2342
  Lab #4
  Schedule Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Schedule
    {
        //====================== PROPERTIES ======================
        public int count = 0;
        public Section[] secArr = new Section[10];

        //====================== CONSTRUCTORS =====================
        public Schedule() { }

        //====================== Behaviors ========================
        // add Section Method
        public void addSection(Section s)
        {
            secArr[count] = s;
            count++;
        }

        //====================== Display Method =====================
        public void display()
        {
            for (int x=0; x< count; x++)
            {
                secArr[x].display();
            }
        }
    }
}
