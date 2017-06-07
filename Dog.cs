using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalProject
{
    class Dog:Pet,IBoardable
    {
        private string size;
        DateTime startdate;
        DateTime enddate;
        public Dog(string petname, string ownername, string color, string size) : base(petname, ownername, color)
        {
            this.size = size;
        }

        public string Getsize()
        {
            return size;

        }
        public new string GetpetInfo()
        {
            string petinfo = "";
            petinfo += petName + "owned by" + ownerName + "\n color" + colour + "\n size" + size;
            return petinfo;
        }
        public void SetBoardStart(int month, int day, int year)
        {
            startdate = new DateTime(year, month, day);
        }

        public void SetBoardEnd(int month, int day, int year)
        {
            enddate = new DateTime(year, month, day);
        }

        public bool Boarding(int month, int day, int year)
        {
            DateTime givenDate = new DateTime(year, month, day);
            if(givenDate >= startdate && givenDate <= enddate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
