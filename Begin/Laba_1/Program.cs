using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных
            int x1, x2;

            System.Console.WriteLine("Введите две координаты точек на оси:");

            // Ввод двух точек
            x1 = System.Convert.ToInt32(System.Console.ReadLine());
            x2 = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Расстояние между отрезками:");

            // Расчёт расстояния между точками и вывод на консоль результат
            System.Console.WriteLine((Math.Abs(x2 - x1)).ToString());

            System.Console.ReadKey();
        }
    }
}
