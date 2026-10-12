using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double a)
        {
            double denominator = 2 * Math.Pow(Math.Cos(a / 2.0), 2);

            if (denominator == 0) return 0;

            return Math.Round(1.0 / denominator, 3);
        }
    }
}
