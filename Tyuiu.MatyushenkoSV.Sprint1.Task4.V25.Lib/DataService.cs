using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double a)
        {
            double rad = a * Math.PI / 180.0;

            double numerator = 1 - Math.Cos(rad);
            double denominator = Math.Pow(Math.Sin(rad), 2);

            if (denominator == 0) return 0;

            return Math.Round(numerator / denominator, 3);
        }
    }
}
