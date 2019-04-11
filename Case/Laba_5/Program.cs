using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных
            /* n1 и n2 - число десятков и единиц;
            age - возраст; s1 и s2 - куски полной
            строки-описания возраста */
            string n1, n2, s1 = "", s2 = "", age;

            System.Console.WriteLine("Введите возраст в диапазоне 20-69 лет:");

            // Ввод возраста
            age = System.Console.ReadLine();

            // Проверка на диапазон
            if (Convert.ToInt32(age) >= 20 && Convert.ToInt32(age) <= 69)
            {
                // Присваивание число десятков и единиц переменным n1 и n2
                n1 = age[0].ToString();
                n2 = age[1].ToString();

                // Выбор правильных строк-описаний данного возраста
                switch (Convert.ToInt32(n1))
                {
                    case 2: s1 = "Двадцать "; break;
                    case 3: s1 = "Тридцать "; break;
                    case 4: s1 = "Сорок "; break;
                    case 5: s1 = "Пятьдесят "; break;
                    case 6: s1 = "Шестьдесят "; break;
                }
                switch (Convert.ToInt32(n2))
                {
                    case 0: s2 = "лет."; break;
                    case 1: s2 = "один год."; break;
                    case 2: s2 = "два года."; break;
                    case 3: s2 = "три года."; break;
                    case 4: s2 = "четыре года."; break;
                    case 5: s2 = "пять лет."; break;
                    case 6: s2 = "шесть лет."; break;
                    case 7: s2 = "семь лет."; break;
                    case 8: s2 = "восемь лет."; break;
                    case 9: s2 = "девять лет."; break;
                }

                System.Console.WriteLine("Ваш возраст звучит как:");

                // Вывод полной строки-описания
                System.Console.WriteLine(s1 + s2);
            }
            else
            {
                // Вывод сообщения о несоответствии возраста
                System.Console.WriteLine("Этот возраст не соответствует диапазону!");
            }

            System.Console.ReadKey();
        }
    }
}
