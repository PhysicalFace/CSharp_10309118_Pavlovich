using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Инициализация переменных:
            а - число сотых;
            b - число десятков;
            c - число единиц;
            number - трёхзначное число*/
            string a, b, c, number;

            System.Console.WriteLine("Введите трёхзначное число:");

            // Ввод трёхзначного числа
            number = System.Console.ReadLine();

            // Присваиваем каждой переменной по соотв-щей цифре
            a = (number[number.Length - 3]).ToString();
            b = (number[number.Length - 2]).ToString();
            c = (number[number.Length - 1]).ToString();

            System.Console.WriteLine("Результат преображения:");

            // Выводим в порядке, в котором требуется от задания
            System.Console.WriteLine(a + c + b);

            System.Console.ReadKey();
        }
    }
}
