using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint3.Task4.V13.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-5, 5);
            Assert.AreEqual(1.899, res, 0.001);
        }
    }
}
