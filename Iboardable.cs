using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalProject
{
    interface IBoardable
    {
         void SetBoardStart(int month, int day, int year);

       void SetBoardEnd(int month, int day, int year);

      bool Boarding(int month, int day, int year);
    }
}
