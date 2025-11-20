using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint4.Task6.V8.Lib;

namespace Tyuiu.Ahmadi2.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}