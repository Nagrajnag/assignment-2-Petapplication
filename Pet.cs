using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalProject
{
    class Pet
    {
        public string petName;
        public string ownerName;
        public string colour;
        protected int _gender;

        public  Pet(string petname, string ownername, string color) //Constructor
        {
            petName = petname;
            ownerName= ownername;
            colour= color;

        }

       public string GetPetName()
        {
            return petName;
        }

      public string GetOwnerName()
        {
            return ownerName;
        }

       public string GetColor()
        {
            return colour;

        }

      public  void SetGender(int sexid)
        {
            this._gender = sexid;
        }


        public string GetGender()
        {
            if(_gender == 1)
            {
                return "male";

            }
            else
            {
                return "female";
            }
        }

        public string GetpetInfo()
        {
           
           
                string petinfo = "";
                petinfo += petName + "owned by" + ownerName + "\n color" + colour + "\n sex" + _gender;
                return petinfo;

            
        }
    }
}
