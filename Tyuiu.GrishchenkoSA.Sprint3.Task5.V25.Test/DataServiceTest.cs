using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint3.Task5.V25.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSumSeries(2, 1, 1, 3, 10);
            Assert.AreEqual(6133.748, res, 0.001);
        }
    }
}
