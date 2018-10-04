/****************************************************
  Boobin Choi
  Lab #2
  Address Class
*****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRegistration
{
    class Address
    {
        //====================== PROPERTIES =====================
        private string street;
        private string city;
        private string state;
        private int zip;

        //====================== CONSTRUCTOR =====================
        public Address()
        {
            street = "";
            city = "";
            state = "";
            zip = 0;
        }

        public Address(string str, string c, string st, int z)
        {
            street = str;
            city = c;
            state = st;
            zip = z;
        }

        //====================== BEHAVIORS =====================

        public string getStreet() { return street; }
        public void setStreet(string str) { street = str; }

        public string getCity() { return city; }
        public void setCity(string c) { city = c; }

        public string getState() { return state; }
        public void setState(string st) { state = st; }

        public int getZip() { return zip; }
        public void setZip(int z) { zip = z; }

        //====================== Display Function =====================
        public void display()
        {
            Console.WriteLine("Address = ");
            Console.WriteLine(getStreet());
            Console.WriteLine(getCity() +", " + getState() +" "+ getZip());
        }
    }
}
