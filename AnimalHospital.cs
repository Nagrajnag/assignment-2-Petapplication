using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalHospitalProject
{
    class AnimalHospital
    {
        List<Dog> dogList = new List<Dog>();
        List<Cat> catList = new List<Cat>();
        List<Bird> birdList = new List<Bird>();

        public AnimalHospital(string inputFile)
        {
            string line = "";
            StreamReader sr = new StreamReader("input.txt");
            while ((line = sr.ReadLine()) != "END")
            {
                string[] lineContents = line.Split(',');
                if (lineContents[0].Equals("DOG"))
                {
                    string petName = lineContents[1];
                    string ownerName = lineContents[2];
                    string color = lineContents[3];
                    string size = lineContents[4];

                    Dog dog = new Dog(petName, ownerName, color, size);
                    dog.SetBoardStart(2, 5, 2005);
                    dog.SetBoardEnd(3, 8, 2009);
                    dogList.Add(dog);
                }
                else if (lineContents[0].Equals("CAT"))
                {
                    lineContents = line.Split(',');
                    if (lineContents[0].Equals("CAT"))
                    {
                        string petName = lineContents[1];
                        string ownerName = lineContents[2];
                        string color = lineContents[3];
                        string hairLength = lineContents[4];



                        Cat cat = new Cat(petName, ownerName, color, hairLength);
                        catList.Add(cat);

                    }
                }
                else if (lineContents[0].Equals("BIRD"))
                {
                    lineContents = line.Split(',');
                    if (lineContents[0].Equals("BIRD"))
                    {
                        string petName = lineContents[1];
                        string ownerName = lineContents[2];
                        string color = lineContents[3];
                        Bird bird = new Bird(petName, ownerName, color);
                        birdList.Add(bird);

                    }
                }
            }
        }


       public void PrintPetInfoByName(string name)
        {
            for (int i = 0; i < dogList.Count; i++)
            {
                //Console.WriteLine("The following are the list of dogs");
                //Console.WriteLine(dogList.ElementAt(i).GetpetInfo());
                if (dogList.ElementAt(i).petName.Equals(name))
                Console.WriteLine(dogList.ElementAt(i).GetpetInfo());
            }
            //for cat
           
            for (int i = 0; i < catList.Count; i++) 
            {
               
                if (catList.ElementAt(i).petName.Equals(name))
                    Console.WriteLine(catList.ElementAt(i).GetpetInfo());
            }
            //for bird
            for (int i = 0; i < birdList.Count; i++)
            {
                if (birdList.ElementAt(i).petName.Equals(name))
                    Console.WriteLine(birdList.ElementAt(i).GetpetInfo());
            }
        }

      public  void PrintPetInfoByOwner(string name)
        {
            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList.ElementAt(i).ownerName.Equals(name))
                    Console.WriteLine(dogList.ElementAt(i).GetpetInfo());
            }
            
            for (int i = 0; i < catList.Count; i++)
            {
                //Console.WriteLine("The following are the list of cats");
                //catList.ElementAt(i).GetpetInfo();
                if (catList.ElementAt(i).ownerName.Equals(name))
                    Console.WriteLine(catList.ElementAt(i).GetpetInfo());
            }
            //for bird
            for (int i = 0; i < birdList.Count; i++)
            {
                if (birdList.ElementAt(i).ownerName.Equals(name))
                    Console.WriteLine(birdList.ElementAt(i).GetpetInfo());
            }
        }

        public void PrintPetsBoarding(int month, int day, int year)
        {
            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList.ElementAt(i).Boarding(month, day, year))
                {
                    Console.WriteLine(dogList.ElementAt(i).GetpetInfo());
                }
            }
        }
    }
}
