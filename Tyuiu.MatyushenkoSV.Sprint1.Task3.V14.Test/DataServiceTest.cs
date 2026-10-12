using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MatyushenkoSV.Sprint1.Task3.V14.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 123;
            double wait = 321;
            var res = ds.ReverseNumber(number);
            Assert.AreEqual(wait, res);
        }
    }
}
