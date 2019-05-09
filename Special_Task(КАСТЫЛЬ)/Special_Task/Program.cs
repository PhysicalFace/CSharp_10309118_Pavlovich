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
        /// Генератор числа элементов в последовательности для входного файла
        /// для тех, кому лень придумывать свои значения.
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
            int count = 0;
            int count_max = 0;
            string max = "";

            using (StreamReader sr = new StreamReader("DIV396.IN"))
            {
                string line;
                int i = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    if (i == 1)
                    {
                        int limit = Int32.Parse(line);
                        if (limit < 1 || limit > 10000)
                        {
                            Console.WriteLine("Ошибка диапазона!");
                            break;
                        }
                    }
                    else
                    {
                        while (line.StartsWith("0"))
                        {
                            line = line.Remove(0, 1);
                        }

                        if (line.Length != 0)
                        {
                            if (line.Length > 9)
                            {
                                for (int k = line.Length; k >= 9; k--)
                                {
                                    int number = Int32.Parse(line.Substring(k - 9, 9));
                                    Console.WriteLine(number);

                                    if (number != 0 && k == line.Length)
                                    {
                                        if (number % 396 == 0)
                                        {
                                            Console.WriteLine("Делится!");

                                            if (max.Length < line.Length)
                                            {
                                                max = line;
                                                count_max = i;
                                                Console.WriteLine("Максималка на номере: "+count_max);
                                            }
                                            else if (max.Length == line.Length)
                                            {
                                                count++;
                                                Console.WriteLine("Количество: " + count);
                                            }

                                            break;
                                        }
                                        else
                                            break;
                                    }

                                    if (number != 0 && number % 396 == 0)
                                    {
                                        Console.WriteLine("Делится!");

                                        if (max.Length < line.Length)
                                        {
                                            max = line;
                                            count_max = i;
                                            count = 1;
                                            Console.WriteLine("Максималка на номере: " + count_max);
                                        }
                                        else if (max.Length == line.Length)
                                        {
                                            count++;
                                            Console.WriteLine("Количество: " + count);
                                        }

                                        break;
                                    }
                                }
                            }
                            else
                            {
                                int number = Int32.Parse(line);
                                Console.WriteLine(number);

                                if (number % 396 == 0)
                                {
                                    Console.WriteLine("Делится!");

                                    if (max.Length < line.Length)
                                    {
                                        max = line;
                                        count_max = i;
                                        count = 1;
                                        Console.WriteLine("Максималка на номере: " + count_max);
                                    }
                                    else if (max.Length == line.Length)
                                    {
                                        count++;
                                        Console.WriteLine("Количество: " + count);
                                    }
                                }
                            }
                        }
                    }

                    i++;
                }
            }

            //Console.WriteLine(count_max);
            //Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
