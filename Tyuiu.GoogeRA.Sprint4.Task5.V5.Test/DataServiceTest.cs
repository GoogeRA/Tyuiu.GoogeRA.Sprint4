using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint4.Task5.V5.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] numsMat = new int[5, 5] { { -7, -9, -7, 6, 7,},
                                          { 8, -8, -5, 5, 7,},
                                          { 8, -6, 5, -4, 7,},
                                          { -9, -9, -7, -8, -7,},
                                          { 5, -9, -9, -8, 9,}, };

            int res = ds.Calculate(numsMat);
            int wait = 58;
            Assert.AreEqual(wait, res);
        }
    }
}
