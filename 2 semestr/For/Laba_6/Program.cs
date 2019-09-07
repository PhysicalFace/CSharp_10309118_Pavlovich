using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0; int N;

            System.Console.WriteLine("Введите нецелое число:");
            A = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Введите целое положительное число:");
            N = Convert.ToInt32(System.Console.ReadLine());

            if (N > 0)
            {
                /* Цикл возведения в степень N числа A в новую переменную B,
                предварительно округляя полученный рез-ат конвертированием в int */
                for (int i = 1; i <= N; i++)
                    B = Convert.ToInt32(Math.Pow(A, i));

                System.Console.WriteLine("Итоговое число:");

                // Вывод конечного числа В
                System.Console.WriteLine(B.ToString());
            }
            else
            {
                // Вывод ошибки числа N
                System.Console.WriteLine("Число N не положительное!");
            }

            System.Console.ReadKey();
        }
    }
}
