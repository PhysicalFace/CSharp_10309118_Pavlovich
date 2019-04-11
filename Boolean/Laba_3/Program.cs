using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменной
            int a;

            System.Console.WriteLine("Введите целое положительное число:");

            // Ввод числа
            a = Convert.ToInt32(System.Console.ReadLine());

            // Проверка на чётность и двузначность
            if ((a % 2 == 0) && (a.ToString().Length == 2))
                System.Console.WriteLine("Число является двузначным чётным!");
            else
                System.Console.WriteLine("Число не является двузначным чётным!");

            System.Console.ReadKey();
        }
    }
}
