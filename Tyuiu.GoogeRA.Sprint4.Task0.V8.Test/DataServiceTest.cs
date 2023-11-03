using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint4.Task0.V8.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsAerey = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = ds.GetMultEvenArrEl(numsAerey);
            int numsWaitArrey = 384;
            Assert.AreEqual(numsWaitArrey, res);

        }
    }
}
