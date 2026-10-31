using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint3.Task2.V30.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(0.25, 1, 11);
            Assert.AreEqual(13051.34, res, 0.001);
        }
    }
}
