using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint3.Task7.V25.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(new double[] { 54.14, 43.07, 39.46, 17.51, 1.48, 1.0, 1.52, -2.49, -24.46, -38.43, -39.52 }, res);
        }
    }
}
