using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            // Ввод нечетного порядка квадратной матрицы
            Console.Write("Введите нечётный порядок квадратной матрицы. М = ");
            int m = int.Parse(Console.ReadLine());

            // Проверка на нечетность
            if (m % 2 == 1)
            {
                // Эта команда нужна для соответствии условия из методички
                m++;

                // Создание двумерного массива
                int[,] a = new int[m, m];

                // Ввод массива
                for (int i = 1; i < m; i++)
                    for (int j = 1; j < m; j++)
                    {
                        Console.Write("Введите элементы массива a[{0},{1}]=", i, j);
                        a[i, j] = int.Parse(Console.ReadLine());
                    }

                // Вывод массива
                Console.WriteLine("Преобразованный массив a:");
                if (m - 1 == 1)
                    Console.Write("\t" + a[1, 1]);
                else
                {
                    // Вначале движемся вниз
                    for (int i = 1; i < m; i++)
                        Console.Write("\t" + a[i, 1]);
                    Console.WriteLine();

                    // Аналогична ситуация с m++
                    m--;

                    // Цикл вывода спирали
                    for (int j = 0; j < m/2; j++)
                    {
                        // Вправо
                        for (int i = 2 + j; i <= m - j; i++)
                            Console.Write("\t" + a[m - j, i]);
                        Console.WriteLine();

                        // Вверх
                        for (int i = m-j-1; i > j; i--)
                            Console.Write("\t" + a[i, m-j]);
                        Console.WriteLine();

                        // Влево
                        for (int i = m-j-1; i >= j+2; i--)
                            Console.Write("\t" + a[j+1, i]);
                        Console.WriteLine();

                        // Вниз
                        for (int i = 2+j; i <= m-j-1; i++)
                            Console.Write("\t" + a[i, j+2]);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                // Вывод ошибки
                Console.WriteLine("Ранг матрицы не соответствует условию!");
            }

            Console.ReadKey();
        }
    }
}
