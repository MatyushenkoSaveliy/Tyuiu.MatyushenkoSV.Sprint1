using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int k = 13257;
            int wait = 3;

            int res = ds.SecondsToHours(k);

            Assert.AreEqual(wait, res);
        }
    }
}
