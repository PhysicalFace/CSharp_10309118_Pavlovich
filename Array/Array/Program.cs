using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод размера одномерного массива
            Console.Write("Введите размер массива n=");
            int n = int.Parse(Console.ReadLine());

            // Инициализация массива размера n
            n++;
            double[] a = new double[n];

            // Ввод значений в каждую ячейку массива
            for (int i = 1; i < n; i++)
            {
                Console.Write("Введите a[{0}]=", i);
                a[i] = double.Parse(Console.ReadLine());
            }

            // Вывод одномерного массива
            Console.WriteLine("Преобразованный массив a:");
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine(a[n-i]);
            }

            Console.ReadKey();


        }
    }
}
