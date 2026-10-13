using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint1.Task7.V28.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 2.0;

            double wait = 2.444;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
