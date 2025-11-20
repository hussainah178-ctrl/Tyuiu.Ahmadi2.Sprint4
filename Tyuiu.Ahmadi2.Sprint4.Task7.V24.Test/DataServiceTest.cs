using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint4.Task7.V24.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string str = "651827384219648";
            int res = ds.Calculate(str);
            int wait = 1179648; // مقدار صحیح

            Assert.AreEqual(wait, res);
        }
    }
}