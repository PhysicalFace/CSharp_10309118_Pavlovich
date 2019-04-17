using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Zadacha_2A
{
    class Program
    {
        public static void Main()
        {
            // Считывание чисел из файла "primes2.in" в переменные M и N
            StreamReader f1 = new StreamReader("primes2.in");
            string[] MN = f1.ReadLine().Split();
            int M = Int32.Parse(MN[0]);
            int N = Int32.Parse(MN[1]);

            // Проверка  M и N на требуемый диапазон
            if (M >= 2 && N <= 1000000)
            {
                // Создание массива логических выражений
                bool[] massive_istini = new bool[N + 1];

                /* Цикл, меняющий в массиве значения false на true, если их индексы не являются простыми числами
                 * Проще говоря, false - простое число, а true - непростое число*/
                for (int i = 2; i <= massive_istini.Length / 2; ++i)
                {
                    if (!massive_istini[i])
                    {
                        for (int j = i * 2; j < massive_istini.Length; j += i)
                        {
                            massive_istini[j] = true;
                        }
                    }
                }

                // Если такой файл для вывода уже есть, удаляем его
                if (File.Exists("primes2.out"))
                {
                    File.Delete("primes2.out");
                }

                // Создаём новый файл для вывода
                File.Create("primes2.out").Close();

                /* Выводим все индексы, которые являются простыми числами(т.е. если в этих индексах значение false),
                 * построчно в файл "primes2.out"*/
                for (int i = M; i <= N; ++i)
                {
                    if (!massive_istini[i])
                    {
                        File.AppendAllText("primes2.out", i.ToString() + "\n");
                    }
                }

                // Если из диапазона вообще нету простых чисел, выдаёт "Absent"
                var f2 = new FileInfo("primes2.out");
                if (f2.Length == 0)
                {
                    File.WriteAllText("primes2.out", "Absent");
                }
            }
            // Иначе выдаёт ошибку о превышении диапазона
            else
            {
                System.Console.WriteLine("В файле primes2.in превышен требуемый диапазон значений!");
                System.Console.ReadKey();
            }
        }
    }
}
