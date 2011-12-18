using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_04
{
    public class Tomcat : Cat
    {

        public Tomcat(string name, byte age)
        {
            Name = name;
            Age = age;
            IsMale = true;
        }

        public override string MakeNoise()
        {
            return "Myaauuuuu .. Grrr!";
        }
    }
}
