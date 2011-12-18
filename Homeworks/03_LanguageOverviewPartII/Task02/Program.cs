using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to check if in a given expression the brackets are put correctly. 
            //Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

            string expression = Console.ReadLine();
            List<char> openBrackets = new List<char>();
            List<char> closedBrackets = new List<char>();
            foreach(char c in expression){
                if (c == '(')
                {
                    openBrackets.Add(c);
                }else if(c== ')'){
                    closedBrackets.Add(c);
                }
            }

            if (closedBrackets.Count != openBrackets.Count)
            {
                Console.WriteLine("invalid expression");
            }
            else
            {
                Console.WriteLine("there is possibility for this expression being correct");
            }

        }
    }
}
