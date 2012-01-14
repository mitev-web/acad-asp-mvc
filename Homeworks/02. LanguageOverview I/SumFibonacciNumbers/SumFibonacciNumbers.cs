using System;
using System.Linq;

class SumFibonacciNumbers
    {
        static void Main(string[] args)
        {

            // Write a program that reads a number N and calculates the sum 
            // of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            //Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

            Console.WriteLine("Please enter a positive int");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            SumFibonacciNums(n);
        }

        static void SumFibonacciNums(int count)
        {
            decimal a = 0;
            decimal b = 1;
            decimal currentFibonacciNumber = 0;
            decimal[] fiboNumbers = new decimal[count];


            for (int i = 0; i < count; i++)
            {
                fiboNumbers[i] = currentFibonacciNumber;

                currentFibonacciNumber = a + b;
                a = b;
                b = currentFibonacciNumber;
                //Console.WriteLine(currentFibonacciNumber);
            }

            try
            {
                Console.WriteLine(fiboNumbers.Sum());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

