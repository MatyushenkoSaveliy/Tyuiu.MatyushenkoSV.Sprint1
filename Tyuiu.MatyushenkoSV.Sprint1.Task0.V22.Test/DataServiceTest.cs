using Tyuiu.MatyushenkoSV.Sprint1.Task0.V22.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(10.0, res);
        }
    }
}
