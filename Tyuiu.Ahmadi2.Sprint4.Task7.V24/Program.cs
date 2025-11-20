using System;
using Tyuiu.Ahmadi2.Sprint4.Task7.V24.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "651827384219648";
            int rows = 5;
            int columns = 3;

            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Размер матрицы: {rows} x {columns}");
            Console.WriteLine();

            // Создание и вывод матрицы
            int[,] matrix = new int[rows, columns];
            int index = 0;

            Console.WriteLine("Матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(str[index].ToString());
                    Console.Write($"{matrix[i, j]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(str);
            Console.WriteLine($"Произведение четных чисел в матрице = {res}");
            Console.ReadKey();
        }
    }
}