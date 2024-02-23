using System;
namespace Task_3_3
{
    public sealed class RectangleArray : TwoDimentionalArray, IPrintSnake
    {

        int[,] Array;

        public RectangleArray(int length1, int length2, bool manualEntry = false)
        {
            if (manualEntry)
            {
                ManualEntry(length1, length2);
            }
            else
            {
                AutoEntry(length1, length2);
            }
        }
        private void ManualEntry(int length1, int length2)
        {
            int n = length1;
            int m = length2;
            Array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        private void AutoEntry(int length1, int length2)
        {
            Random rnd = new Random();
            int n = length1;
            int m = length2;
            Array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Array[i, j] = rnd.Next(-200, 200);
                }
            }
        }
        public override double AverageValue()
        {
            int summa = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    summa += Array[i, j];
                }
            }
            return summa / (Array.GetLength(0) * Array.GetLength(1));
        }
        public override void Print()
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();

            }
        }
        public void PrintSnake()
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = Array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write($"{Array[i, j]} ");
                    }
                }
                else
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Console.Write($"{Array[i, j]} ");
                    }
                }
                Console.WriteLine();


            }
        }

    }
}

