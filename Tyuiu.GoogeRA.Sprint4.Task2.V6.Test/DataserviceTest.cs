using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint4.Task2.V6.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsAerey = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9 };
            int res = ds.Calculate(numsAerey);
            int numsWaitArrey = 30625;
            Assert.AreEqual(numsWaitArrey, res);


        }
    }
}
