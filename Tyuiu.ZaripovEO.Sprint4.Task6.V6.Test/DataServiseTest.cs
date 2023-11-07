using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint4.Task6.V6.Lib;

namespace Tyuiu.ZaripovEO.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var name = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] res = ds.Calculate(name);
            string[] wait = { "Борис", "Ирина"};
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
