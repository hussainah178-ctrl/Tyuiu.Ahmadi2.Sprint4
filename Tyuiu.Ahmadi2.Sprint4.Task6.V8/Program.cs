using System;
using Tyuiu.Ahmadi2.Sprint4.Task6.V8.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(array);

            Console.WriteLine("Элементы массива, длина которых больше 4 символов:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]}");
                if (i < res.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}