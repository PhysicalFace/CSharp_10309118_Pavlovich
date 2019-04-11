using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    class Program
    {
        // Ф-ция Sign() с вещ-ным аргументом n
        static double Sign(double n)
        {
            // Возвращает -1 при n<0; 1 при n>0; 0 при n==0
            return n < 0 ? -1 : n == 0 ? 0 : 1;
        }

        static void Main(string[] args)
        {
            // Инициализация переменных
            double A, B;
            System.Console.WriteLine("Введите два нецелых числа:");

            // Ввод данных
            System.Console.Write("1-е число: ");
            A = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("2-е число: ");
            B = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Результат вычисления Sign(A) + Sign(B):");

            // Вывод рез-та вычисления
            System.Console.WriteLine((Sign(A) + Sign(B)).ToString());

            System.Console.ReadKey();
        }
    }
}
