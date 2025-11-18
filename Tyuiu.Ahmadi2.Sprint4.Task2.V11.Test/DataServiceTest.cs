using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint4.Task2.V11.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 5, 3, 6, 8, 7, 4, 5, 6, 8, 3, 4, 7, 8, 6 };
            int res = ds.Calculate(array);

            // اعداد زوج در آرایه: 4, 6, 8, 4, 6, 8, 4, 8, 6
            int wait = 4 + 6 + 8 + 4 + 6 + 8 + 4 + 8 + 6;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithOnlyEven()
        {
            DataService ds = new DataService();
            int[] array = { 4, 6, 8, 4, 6, 8, 4, 6, 8, 4, 6, 8, 4, 6, 8 };
            int res = ds.Calculate(array);
            int wait = 4 + 6 + 8 + 4 + 6 + 8 + 4 + 6 + 8 + 4 + 6 + 8 + 4 + 6 + 8;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithOnlyOdd()
        {
            DataService ds = new DataService();
            int[] array = { 3, 5, 7, 3, 5, 7, 3, 5, 7, 3, 5, 7, 3, 5, 7 };
            int res = ds.Calculate(array);
            int wait = 0; 
            Assert.AreEqual(wait, res);
        }
    }
}