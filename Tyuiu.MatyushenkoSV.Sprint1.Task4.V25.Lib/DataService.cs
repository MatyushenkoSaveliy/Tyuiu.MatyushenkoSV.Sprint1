using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double x)
        {
            double numerator = 1 - Math.Cos(x);
            double denominator = Math.Pow(Math.Sin(x), 2);

            if (Math.Abs(denominator) < 1e-7)
            {
                return 0;
            }

            double res = numerator / denominator;
            return Math.Round(res, 3);
        }
    }
}
