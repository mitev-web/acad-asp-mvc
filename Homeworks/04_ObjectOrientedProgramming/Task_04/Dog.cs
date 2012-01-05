using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_04
{
    public class Dog : Animal
    {

        public Dog(string name, byte age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public string MakeNoise()
        {
            return "Bark, bark";
        }
    }



}
