using System;
using System.Linq;

class FactorialSum
{
    static void Main(string[] args)
    {
        //Write a program that, for a given two integer numbers N and X, 
        //calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

        int S = new int();
        int N;
        int X;
        string inputLine;

        Console.WriteLine("Please enter value for N:");
        inputLine = Console.ReadLine();
        int.TryParse(inputLine, out N);

        Console.WriteLine("Please enter value for X:");
        inputLine = Console.ReadLine();
        int.TryParse(inputLine, out X);

        for (int i = 1; i <= N; i++)
        {
            S += i + Factorial(i) / X * i;
        }
        Console.WriteLine(S);

    }

    private static int Factorial(int x)
    {
        int factorial = 1;
        for (int i = 1; i < x; i++)
        {
            factorial += factorial * i;
        }

        return factorial;
    }
}

