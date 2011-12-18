using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_04
{
    public class Cat : Animal
    {

        public Cat()
        {

        }
        public Cat(string name, byte age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }
        public virtual string MakeNoise()
        {
            return "Myauu";
        }
    }
}
