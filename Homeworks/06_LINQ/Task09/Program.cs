using System;

using System.Linq;
using System.Text;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to return the string with maximum length from an array of strings. Use LINQ.

            string[] arr = { "pesho", "gosho", "krokodil" };

            //var strLenMax = (from s in arr
            //                orderby s.Length
            //                select s).Last();

            var strLenMax = (arr.Select(x => x).OrderBy(x => x.Length)).Last();

                Console.WriteLine(strLenMax);
           
        }
    }
}
