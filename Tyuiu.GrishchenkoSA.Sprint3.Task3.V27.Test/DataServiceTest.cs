using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint3.Task3.V27.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.ConvertStringToInt(!bt, g567kid f!);
            Assert.AreEqual(567, res);
        }
    }
}
