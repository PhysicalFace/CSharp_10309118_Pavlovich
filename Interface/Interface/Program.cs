using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    struct WORKER
    {
        public string Surname;
        public string Initials;
        public string Post;
        public int Date;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var f = true;
            const int N = 3;

            WORKER[] worker = new WORKER[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите информацию о сотруднике №" + (i + 1).ToString() + ":\n");
                Console.Write("\tФамилия: ");  worker[i].Surname = Console.ReadLine();
                Console.Write("\tИнициалы: "); worker[i].Initials = Console.ReadLine();
                Console.Write("\tДолжность: "); worker[i].Post = Console.ReadLine();
                Console.Write("\tГод поступления на работу: "); worker[i].Date = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------------------\n");
            }

            Console.Write("Введите стаж работы в организации: ");
            int experience = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                if ((DateTime.Now.Year - worker[i].Date) > experience)
                {
                    Console.WriteLine(worker[i].Surname);
                    f = false;
                }
            }

            if (f)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tТаких работников нету!");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
