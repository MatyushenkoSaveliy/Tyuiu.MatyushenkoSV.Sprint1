using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 60;
            double wait = 0.667;

            var res = ds.Calculate(a);

            Assert.AreEqual(wait, res);
        }
    }
}