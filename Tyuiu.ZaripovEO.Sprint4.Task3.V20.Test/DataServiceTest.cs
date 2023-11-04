using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint4.Task3.V20.Lib;

namespace Tyuiu.ZaripovEO.Sprint4.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[3, 3] { { 7, 2, 3 }, { 4, 5, 6 }, { 10, 8, 9 } };
            int res = ds.Calculate(mas2);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
