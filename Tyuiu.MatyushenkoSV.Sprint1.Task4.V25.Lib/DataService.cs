using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double a)
        {
            double numerator = 1 - Math.Cos(a);
            double denominator = Math.Pow(Math.Sin(a), 2);
            double res = denominator != 0 ? numerator / denominator : 0;

            return Math.Round(res, 3);
        }
    }
}