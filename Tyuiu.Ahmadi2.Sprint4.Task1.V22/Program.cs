using System;
using Tyuiu.Ahmadi2.Sprint4.Task1.V22.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите 12 элементов массива в диапазоне от 2 до 9:");
            int[] array = new int[12];

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                
                if (array[i] < 2 || array[i] > 9)
                {
                    Console.WriteLine("Ошибка! Число должно быть в диапазоне от 2 до 9.");
                    i--; 
                }
            }

            Console.WriteLine();
            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Произведение нечётных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}