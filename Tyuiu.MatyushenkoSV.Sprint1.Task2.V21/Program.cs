using System;
using Tyuiu.MatyushenkoSV.Sprint1.Task2.V21.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Матюшенко С. В. | Вариант #21";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Матюшенко Савелий Владимирович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известны длины стороны прямоугольника. Вычислить площадь прямоугольника *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину первой стороны прямоугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину второй стороны прямоугольника: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь прямоугольника = " + ds.CalculateRectangleSquare(a, b));

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
