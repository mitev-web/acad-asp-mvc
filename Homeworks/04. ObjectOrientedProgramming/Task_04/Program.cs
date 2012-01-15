using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define suitable constructors and methods according to the following rules:
            //all of this are Animals. Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female
            //and tomcats can be only male. Each animal produce a sound. Create arrays of different kinds of animals and calculate the average age
            //of each kind of animal using static methods. Create static method in the animal class that identifies the animal by its sound.

            Dog[] doggies = new Dog[] { new Dog("johnny", 21, true), new Dog("pencho", 44, true), new Dog("ivan", 12, true) };
            Frog[] froggies = new Frog[] { new Frog("johnny", 5, true), new Frog("boris", 7, true), new Frog("galina", 3, true) };
            Cat[] cats = new Cat[] { new Cat("kika", 25, false), new Cat("Boris", 27, true), new Cat("Tiger", 33, true) };
            Kitten[] kittens = new Kitten[] { new Kitten("mimi", 3), new Kitten("krisi", 1), new Kitten("penka", 6) };
            Tomcat[] tomcats = new Tomcat[] { new Tomcat("pesho", 3), new Tomcat("boiko", 1), new Tomcat("borko", 6) };

            Console.WriteLine("Average age of doggies is {0} months", Animal.AverageAge(doggies));
            Console.WriteLine("Average age of froggies is {0} months", Animal.AverageAge(froggies));
            Console.WriteLine("Average age of cats is {0} months", Animal.AverageAge(cats));
            Console.WriteLine("Average age of kittens is {0} months", Animal.AverageAge(kittens));
            Console.WriteLine("Average age of tomcats is {0} months", Animal.AverageAge(tomcats));

            Tomcat whatAmI = new Tomcat("Tom", 7);

            Console.WriteLine("What is this animal?");
            Console.WriteLine("The animal is {0}",Animal.IdentifyByNoise(whatAmI.MakeNoise()));
        }
    }
}
