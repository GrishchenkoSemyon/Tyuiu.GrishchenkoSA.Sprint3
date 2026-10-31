using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint3.Task6.V11.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(10, 19);
            Assert.AreEqual(9, res);
        }
    }
}
