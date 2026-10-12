using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double res = ds.Calculate(a);

            double wait = Math.Round((1 - Math.Cos(a)) / Math.Pow(Math.Sin(a), 2), 3);

            Assert.AreEqual(wait, res);
        }
    }
}
