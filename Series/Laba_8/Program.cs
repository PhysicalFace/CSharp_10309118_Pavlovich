using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Инициализация переменных
            K - целое число для сравнения чисел из списка myList
            N - Через него будет вводиться список из чисел
            пользователем, а также для выведения номера
            числа из списка myList, к-рое > K */
            int K, N = 1;

            // Создание списка
            List<int> myList = new List<int>();

            System.Console.WriteLine("Введите целое число 'K':");

            // Ввод числа 'K' пользователем
            K = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Введите набор ненулевых чисел; ноль, чтобы закончить набор:");

            /* Цикл создания списка из чисел пользователя.
            Прерывается, если введённое пользователем число явл. ноль. */
            for (int i = 1; ; i++)
            {
                System.Console.Write(i.ToString() + "-е число из набора: ");

                // Ввод числа i-го номера из списка
                N = Convert.ToInt32(System.Console.ReadLine());

                // Прерываем цикл
                if (N == 0)
                    break;

                // Добавляем число пользователя в список
                myList.Add(N);
            }

            // Цикл нахождения номера последнего числа, большего, чем 'K'
            // Перем. index будет играть роль счётчика для списка
            int index = 1;

            foreach (int j in myList)
            {
                // Приравниваем N к номеру числа, большего, чем 'K'
                if (j > K)
                    N = index;

                index++;
            }

            // Если такое число нашли - выводим его номер из списка
            if (N != 0)
            {
                System.Console.WriteLine("Номер последнего числа из набора, большего числа 'K':");
                System.Console.WriteLine(N.ToString() + "-й номер из набора!");
            }
            // Иначе, выводим ноль
            else
                System.Console.WriteLine("Таких чисел из набора нет! 0");

            System.Console.ReadKey();
        }
    }
}
