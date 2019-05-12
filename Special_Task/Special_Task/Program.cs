using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Special_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count_max = 0;
            string max = "";

            // Считываем данные из файла DIV396.IN построчно
            using (StreamReader sr = new StreamReader("DIV396.IN"))
            {
                String line;
                int stroka = 0;

                // Считываем информацию с файла построчно, пока следующие строки файла не окажутся пустыми
                while ((line = sr.ReadLine()) != null)
                {
                    stroka++;
                    string this_line = line;

                    if (stroka == 1)
                    {
                        // Проверяем на корректный диапазон
                        int limit = Int32.Parse(line);
                        if (limit < 1 || limit > 10000)
                        {
                            Console.WriteLine("Ошибка диапазона!");
                            break;
                        }
                    }
                    else
                    {
                        // Пока длина строки больше 9 знаков, делим кусочно
                        while (line.Length > 9)
                        {
                            var piece_of_number = (Int32.Parse(line.Substring(0, 9)) % 396);
                            line = line.Remove(0, 9);
                            line = line.Insert(0, piece_of_number.ToString());
                        }

                        
                        int number = Int32.Parse(line);

                        // Проверка делимости числа на 396 без остатка
                        if (number % 396 == 0)
                        {
                            if (max.Length < this_line.Length)
                            {
                                max = this_line;
                                count = 1;
                                count_max = stroka;
                            }
                            else if (max.Length == this_line.Length)
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
