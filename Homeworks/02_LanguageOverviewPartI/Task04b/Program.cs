using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task04b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of the matrix (N)");
            int N = new int();
            int.TryParse(Console.ReadLine(), out N);
            int[,] matrix = new int[N, N];

            PopulateMatrix(matrix);
            PrintMatrix(matrix);
        }

        private static void PopulateMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(1);
            int count = n * n;

            int positionY = n - 1;
            int positionX = n - 1;

            for (int currentNumber = 1; currentNumber <= count; currentNumber++, positionY--)
            {
                matrix[positionY, positionX] = currentNumber;

                if ((positionX == n - 1) && positionY != 0)
                {
                    positionX = positionY - 1;
                    positionY = n;
                }
                else if (positionY == 0)
                {
                    positionY = positionX;
                    positionX = 0;
                }
                else
                {
                    positionX++;
                }

            }
        }
        private static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
