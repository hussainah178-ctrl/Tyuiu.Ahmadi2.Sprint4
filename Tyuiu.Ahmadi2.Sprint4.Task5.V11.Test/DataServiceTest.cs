using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint4.Task5.V11.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                {-5, -3, 2, -2, 1},
                {-6, 1, -5, 0, 2},
                {-1, 2, -4, 1, -4},
                {4, -1, -4, -4, -5},
                {-4, 6, -1, -1, 2}
            };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] {
                {-5, -3, 1, -2, 1},
                {-6, 1, -5, 0, 1},
                {-1, 1, -4, 1, -4},
                {1, -1, -4, -4, -5},
                {-4, 1, -1, -1, 1}
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}