using System;
using Tyuiu.Ahmadi2.Sprint4.Task0.V11.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetMultOddArrEl(array);
            Console.WriteLine("Произведение нечётных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}