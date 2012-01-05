using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints to the console which day of the week is today. 
            //Use System.DateTime.

            DateTime date = DateTime.Now;
            Console.WriteLine("today is {0}", date.DayOfWeek);

        }
    }
}
