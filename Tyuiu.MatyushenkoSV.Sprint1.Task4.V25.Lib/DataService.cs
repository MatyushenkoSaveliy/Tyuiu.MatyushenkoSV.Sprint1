using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double a)
        {
            double result = 1.0 / (1.0 + Math.Cos(a));

            return Math.Round(result, 3);
        }
    }
}
