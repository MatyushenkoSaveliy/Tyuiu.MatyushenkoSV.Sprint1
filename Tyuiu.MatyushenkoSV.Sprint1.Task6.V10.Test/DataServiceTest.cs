using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint1.Task6.V10.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string text = "доход";
            string wait = "доод";

            string res = ds.DeleteMiddleLetter(text);

            Assert.AreEqual(wait, res);
        }
    } 
}
