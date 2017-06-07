using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalProject
{
    class Cat:Pet,IBoardable
    {
        private string size;
        DateTime startdate;
        DateTime enddate;
        private string hairlength;

        public Cat(string petname, string ownername, string color,string hairLength) : base(petname, ownername, color)
        {
            hairlength = hairLength;
        }
        public string Gethairlength()
        {
            string hairlength;
            hairlength = "short";
            return hairlength;

        }
        public new string GetpetInfo()
        {
            base.GetpetInfo();
            string petinfo = "";
            petinfo += petName + "owned by" + ownerName + "\n color" + colour + "\n hair" + hairlength ;
            return petinfo;
        }
        public void SetBoardStart(int month, int day, int year)// implementation from interface
        {
            startdate = new DateTime(year, month, day);
        }

        public void SetBoardEnd(int month, int day, int year)
        {
            enddate = new DateTime(year, month, day);
        }

        public bool Boarding(int month, int day, int year)
        {
            
            return true;
        }
    
    }
}
