using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint3.Task1.V24.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSeries(5, 1, 12);
            Assert.AreEqual(0.222, res, 0.001);
        }
    }
}
