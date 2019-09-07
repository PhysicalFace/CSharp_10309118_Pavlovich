using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных
            double A, B, C;

            System.Console.WriteLine("Введите по порядку три нецелых числа:");

            // Ввод вещественных чисел
            A = Convert.ToDouble(System.Console.ReadLine());
            B = Convert.ToDouble(System.Console.ReadLine());
            C = Convert.ToDouble(System.Console.ReadLine());

            // Проверка
            if ((A < B) && (B < C))
            {
                System.Console.WriteLine("Числа идут по порядку возрастания!");
                A *= 2; B *= 2; C *= 2;
            }
            else
            {
                System.Console.WriteLine("Числа не идут по порядку возрастания!");
                A = -A; B = -B; C = -C;
            }

            System.Console.WriteLine("Преобразованные значения:");

            // Вывод преобразованных переменных
            System.Console.WriteLine(A.ToString() + ',' + B.ToString() + ',' + C.ToString());

            System.Console.ReadKey();
        }
    }
}
