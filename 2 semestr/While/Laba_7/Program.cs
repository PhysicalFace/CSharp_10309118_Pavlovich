using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Инициализиция переменных
            S - суммарный пробег
            R - пробег, увел-щийся с каждым днём на P %-тов
            K - кол-во дней пробежки */
            double S = 10, R = 10, P; int K = 1;

            System.Console.WriteLine("Введите вещ-ное число от 0 до 50 (не включ-но):");

            // Ввод числа процентов увеличения длины пробега на каждый день
            P = Convert.ToDouble(System.Console.ReadLine());

            // Проверка числа P на корректный диапазон
            if (P > 0 && P < 50)
            {
                // Цикл увел-ния суммарного пробега S, пробега за день R и кол-ва дней K
                while (S < 200)
                {
                    R += R * (P / 100);
                    S += R;
                    K++;
                }

                // Вывод результатов
                System.Console.WriteLine("Спортсмен превысил 200 км за " + K.ToString() + " дней!");
                System.Console.WriteLine("Суммарный пробег: " + S.ToString());
            }
            else
            {
                // Вывод ошибки числа P
                System.Console.WriteLine("Ваше число не соотв-ет диапазону!");
            }

            System.Console.ReadKey();
        }
    }
}
