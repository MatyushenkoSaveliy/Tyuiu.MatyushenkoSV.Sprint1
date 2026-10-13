using System;
using Tyuiu.MatyushenkoSV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Матюшенко С. В. | Вариант #4";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Матюшенко Савелий Владимирович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит количество полных часов (h),        *");
            Console.WriteLine("* прошедших к моменту k-й секунды суток.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество секунд k:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int h = ds.SecondsToHours(k);
            Console.WriteLine("Количество полных часов = " + h);

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
