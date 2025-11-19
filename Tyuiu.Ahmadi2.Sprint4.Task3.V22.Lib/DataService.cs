using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Ahmadi2.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int max = array[0, 0];

            for (int j = 0; j < columns; j++)
            {
                if (array[0, j] > max)
                {
                    max = array[0, j];
                }
            }
            return max;
        }
    }
}