using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_04
{
    public class Kitten : Cat
    {


        public Kitten(string name, byte age)
        {
            Name = name;
            Age = age;
            IsMale = false;
        }


        public override string MakeNoise()
        {
            return "Myaauuu myauu!";
        }
    }
}
