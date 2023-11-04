using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint4.Task2.V29.Lib;

namespace Tyuiu.ZaripovEO.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 6, 3, 6, 7, 9 };

            int res = ds.Calculate(numsArray);
            int wait = 144;

            Assert.AreEqual(wait, res);
        }
    }
}
