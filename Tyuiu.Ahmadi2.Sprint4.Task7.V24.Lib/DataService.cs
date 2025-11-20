using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Ahmadi2.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(string str)
        {
            int rows = 5;
            int columns = 3;
            int[,] matrix = new int[rows, columns];

            int index = 0;
            int product = 1;
            bool hasEven = false;

            // Преобразование строки в матрицу
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(str[index].ToString());
                    index++;

                    // Проверка на четность и вычисление произведения
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }

            return hasEven ? product : 0;
        }

        public int Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }
    }
}