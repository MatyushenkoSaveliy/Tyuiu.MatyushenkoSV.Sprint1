using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double x)
        {
            double res = (1 - Math.Cos(x)) / Math.Pow(Math.Sin(x), 2);
            res = Math.Round(res, 3);
            return res;
        }
    }
}