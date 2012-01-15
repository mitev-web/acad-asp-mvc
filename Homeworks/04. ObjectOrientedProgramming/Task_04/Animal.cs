using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_04
{
   public abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       //the age is in months
        private ushort age;

        public ushort Age
        {
            get { return age; }
            set { age = value; }
        }

        private bool isMale;

        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }

        public Animal()
        {

        }
        public Animal(string name, byte age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }



        public static string IdentifyByNoise(string noise){

            switch(noise)
            {
                case "Myauu": return "Cat!";
                case "Bark, bark": return "Dog!"; 
                case "Kwaqu Kwaqu!": return "Frog!";
                case "Myaauuu myauu!": return "Kitten!"; 
                case "Myaauuuuu .. Grrr!": return "Tomcat!"; 
                default:
                return "unknown animal";
            }
        }


        public static uint AverageAge(Animal[] animals)
        {
            uint averageAge = 0;
            foreach(Animal a in animals){
                averageAge += a.Age;
            }
            averageAge /= (uint)animals.Count();
            return averageAge;
        }
    }
}
