using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint4.Task5.V28.Lib;

namespace Tyuiu.ZaripovEO.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { 3, -6, 4, 6, 6 }, { 7, -5, 5, 5, -8 }, { 8, -3, 6, -7, 7 }, { 5, 3, -8, -4, -5 }, { 3, 7, 4, 3, 8 } };
            int[,] res = ds.Calculate(mas);
            int[,] wait = { { 3, 0, 4, 6, 6 }, { 7, 0, 5, 5, 0 }, { 8, 0, 6, 0, 7 }, { 5, 3, 0, 0, 0 }, { 3, 7, 4, 3, 8 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
