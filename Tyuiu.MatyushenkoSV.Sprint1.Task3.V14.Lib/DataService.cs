using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            int num = Convert.ToInt32(number);

            int hundreds = num / 100;
            int tens = (num / 10) % 10;
            int units = num % 10;

            double reversed = units * 100 + tens * 10 + hundreds;

            return reversed;
        }
    }
}
