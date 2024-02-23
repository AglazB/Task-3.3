using System;
namespace Task_3_3
{
	public abstract class TwoDimentionalArray : IRoot
	{
        public int Rank()
        {
            return 2;
        }
        public abstract double AverageValue();
        public abstract void Print();
    }
}

