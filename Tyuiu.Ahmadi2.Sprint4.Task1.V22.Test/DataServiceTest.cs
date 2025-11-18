using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint4.Task1.V22.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 3, 4, 4, 9, 2 };
            int res = ds.Calculate(array);
            int wait = 5 * 3 * 9 * 9 * 3 * 9; // 32805
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithGivenData()
        {
            DataService ds = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 3, 4, 4, 9, 2 };
            int res = ds.Calculate(array);
            int wait = 32805;
            Assert.AreEqual(wait, res);
        }
    }
}