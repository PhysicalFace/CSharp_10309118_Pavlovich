using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Numerics;

namespace Special_Task
{
    class Program
    {
        /// Генератор числа элементов из цифр в последовательности для входного файла DIV396.IN.
        /// Ф-ция для тех, кому лень придумывать свои значения.
        /// Просто введите вначале исходного кода эту ф-цию и будет вам счастье.
        static void ToGenerateDIV396()
        {
            Console.Write("Введите число элементов в последовательности: ");
            int lines = Int32.Parse(Console.ReadLine());

            using (StreamWriter sw = new StreamWriter("DIV396.IN"))
            {
                sw.WriteLine(lines);
                Random rnd = new Random();

                for (int i = 0; i < lines; i++)
                {
                    var chars = "0123456789";
                    var stringChars = new char[rnd.Next(1, 30000) - 1];

                    for (int j = 0; j < stringChars.Length; j++)
                    {
                        stringChars[j] = chars[rnd.Next(chars.Length)];
                    }

                    var finalString = new String(stringChars);
                    sw.WriteLine(finalString);
                }
            }
        }

        /// Исходный код.
        static void Main(string[] args)
        {
            int count = 0; // счётчик кол-ва max-ных значений
            int count_max = 0; // номер строки max-ого значения
            BigInteger max = 0; // эта переменная будет сравниваться со значениями каждой строки

            // Считываем данные из файла DIV396.IN построчно
            using (StreamReader sr = new StreamReader("DIV396.IN"))
            {
                string line;
                int i = 0; // счётчик строк в файле

                // Считываем информацию с файла построчно, пока строки этого файла не будут пустыми
                while ((line = sr.ReadLine()) != null)
                {
                    i++;

                    if (i == 1)
                    {
                        // Проверяем на корректный диапазон
                        int limit = Int32.Parse(line);
                        if (limit < 1 || limit > 10000)
                        {
                            Console.WriteLine("Ошибка диапазона!");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        BigInteger number = BigInteger.Parse(line);

                        // Проверка делимости числа на 396 без остатка
                        if (number % 396 == 0)
                        {
                            if (max < number)
                            {
                                max = number;
                                count = 1;
                                count_max = i;
                            }
                            else if (max == number)
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            // Записываем результат в файл DIV396.OUT в зависимости от того, сколько
            // раз встретилась max-ное целое положительное число, делимое на 396 (т.е. count)
            using (StreamWriter sw = new StreamWriter("DIV396.OUT"))
            {
                switch (count)
                {
                    // Если таких нет - ноль
                    case 0: sw.Write("0"); break;

                    // Если такой один единственный - номер этого числа в файле
                    case 1: sw.Write(count_max); break;

                    // Если таких несколько - их количество в файле
                    default: sw.Write(count); break;
                }
            }
        }
    }
}
