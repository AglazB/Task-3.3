using System;
namespace Task_3_2
{
    public sealed class OneDimentionalArray : RootClass
    {
        private int[] Array;
        public OneDimentionalArray(int length, bool manualEntry = false)
        {
            if (manualEntry)
            {
                ManualEntry(length);
            }
            else
            {
                AutoEntry(length);
            }
        }
 
        private void ManualEntry(int length)
        {
            int n = length;
            Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void AutoEntry(int length)
        {
            Random rnd = new Random();
            int n = length;
            Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = rnd.Next(-200, 200);
            }
        }

        public override double AverageValue()
        {
            double summa = 0;
            foreach (int el in Array)
            {
                summa += el;
            }
            return summa / Array.Length;

        }
        public override int Rank()
        {
            return 1;
        }
        public int GetElement(int i)
        {
            return Array[i];
        }
        public int GetLength()
        {
            return Array.Length;
        }
        public int SetValue(int i, int x, int y)
        {
            Array[i] = x * y;
            return Array[i];
        }
        public void DeleteElementsGreate100()
        {
            int n = Array.Length;
            foreach (int el in Array)
            {
                if (Math.Abs(el) > 100)
                {
                    n = n - 1;
                }
            }
            int[] ArrayElementsLess100 = new int[n];
            int i = 0;
            foreach (int el in Array)
            {
                if (Math.Abs(el) <= 100)
                {
                    ArrayElementsLess100[i] = el;
                    i = i + 1;
                }
            }
            Array = ArrayElementsLess100;
        }
        public void DeleteDublicates()
        {
            int[] ArrayWithoutDublicates = Array.Distinct().ToArray();
            Array = ArrayWithoutDublicates;
        }

        public void Print()
        {
            foreach (int el in Array)
            {
                Console.Write($"{el}, ");
            }
        }
    }
}

