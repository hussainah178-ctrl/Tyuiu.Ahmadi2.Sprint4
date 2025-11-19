using System;
using Tyuiu.Ahmadi2.Sprint4.Task3.V22.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {4, 4, 7, 8, 9},
                {9, 5, 9, 7, 8},
                {7, 4, 9, 4, 6},
                {4, 4, 7, 4, 4},
                {4, 5, 8, 6, 7}
            };

            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Максимальный элемент в первой строке = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}