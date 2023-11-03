using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint4.Task1.V23.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsAerey = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
            int res = ds.Calculate(numsAerey);
            int numsWaitArrey = 36;
            Assert.AreEqual(numsWaitArrey, res);
        }
    }
}
