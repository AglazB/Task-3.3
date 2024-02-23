using System;
using System.Linq;
using Task_3_3;
using static System.Runtime.InteropServices.JavaScript.JSType;

class HelloWorld
{
    static void Main()
    {
        IRoot[] MyArray = new IRoot[3];
        Console.WriteLine("Введите длину массива");
        int length = int.Parse(Console.ReadLine());
        OneDimentionalArray oneDimensionalArray = new OneDimentionalArray(length);
        MyArray[0] = oneDimensionalArray;
        Console.WriteLine("Демонстрация работы с двумерным массивом");
        Console.WriteLine("Введите количество строк массива");
        int firstlength = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов массива:");
        int secondlength = int.Parse(Console.ReadLine());
        RectangleArray RectangleArray = new RectangleArray(firstlength, secondlength);
        MyArray[1] = RectangleArray;
        Console.WriteLine("Демонстрация работы со ступенчатым массивом:");
        Console.WriteLine("Введите длину массива");
        int length2 = int.Parse(Console.ReadLine());
        JaggedArray jaggedlArray = new JaggedArray(length2);
        MyArray[2] = jaggedlArray;
        for (int i = 0; i < MyArray.Length; i++)
        {
            Console.WriteLine($"Печатаем {i + 1} массив");
            MyArray[i].Print();
            Console.WriteLine($"среднее значение: {MyArray[i].AverageValue()}");
            Console.WriteLine();
        }
        IPrinter p = new WeekDays();
        p.Print();
    }
}

