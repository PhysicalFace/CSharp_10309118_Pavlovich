using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дан массив из известных значений
            double[] numb = new double[22];
            numb[0] = 0; numb[1] = 0; numb[2] = 0; numb[3] = 0.54; numb[4] = 0.96; numb[5] = 1.36;
            numb[6] = 1.64; numb[7] = 1.88; numb[8] = 2.02; numb[9] = 2.26; numb[10] = 2.38; numb[11] = 2.5;
            numb[12] = 2.52; numb[13] = 2.66; numb[14] = 2.72; numb[15] = 2.76; numb[16] = 2.8; numb[17] = 2.82;
            numb[18] = 2.9; numb[19] = 2.92; numb[20] = 2.94; numb[21] = 2.96;

            // Создание класса StreamWriter
            StreamWriter w = new StreamWriter("1.txt", false);

            // Запись массива numb в файл
            foreach (double el in numb) w.WriteLine(el);
            w.Close();

            // Чтение данных из того же файла
            StreamReader r = new StreamReader("1.txt");

            // Вывод всех непустых строк в консоль
            string str;
            while ((str = r.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
