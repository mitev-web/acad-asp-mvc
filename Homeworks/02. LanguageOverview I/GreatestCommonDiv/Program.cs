using System;
using System.Linq;

class GreatestCommonDiv
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
   

        static void Main(string[] args)
        {
            Console.WriteLine("Lets find the GDC between two numbers");
            Console.WriteLine("Enter first integer");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            long b = long.Parse(Console.ReadLine());
            Console.WriteLine("Greatest Commond Divisor is:");
            Console.WriteLine(FindGreatestCommonDivisor(a, b));
        }


       private static long FindGreatestCommonDivisor(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return (FindGreatestCommonDivisor(b, a % b));
            }

        }
    }
