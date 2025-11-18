using System;
using Tyuiu.Ahmadi2.Sprint4.Task2.V11.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rand = new Random();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[15];

           
            Console.Write("Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(3, 9); 
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Сумма чётных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}