using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint1.Task2.V21.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 6;

            int expected = 30;
            int res = ds.CalculateRectangleSquare(a, b);

            Assert.AreEqual(expected, res);
        }
    }
}
