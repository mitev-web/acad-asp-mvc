using System;
using System.Linq;


    class RoundOuterMatrix
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
            int N = matrix.GetLength(0);
            int count = N * N;
            int positionX = 0;
            int positionY = -1;

            int direction = 0;
            int currentStep = 0;
            int stepChange = N - 1;

            for (int j = 1; j <= N; j++)
            {
                positionY++;
                matrix[positionY, positionX] = j;
            }

            for (int i = N + 1; i <= N * N; i++)
            {
                currentStep++;
                switch (direction % 4)
                {

                    case 0:
                        //go right
                        positionX++;
                        break;
                    case 1:
                        //go up
                        positionY--;
                        break;
                    case 2:
                        //go left
                        positionX--;
                        break;
                    case 3:
                        //go down
                        positionY++;
                        break;
                }

                if (currentStep == stepChange)
                {
                    currentStep = 0;
                    direction++;
                    if (direction % 2 == 0)
                    {
                        stepChange--;
                    }
                }

                matrix[positionY, positionX] = i;
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

