using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{ 
    abstract class Tovar
    {
        // Дата производства.
        protected DateTime ManufactureDate;
 
        // Название продукта.
        protected string Name;
 
        // Цена.
        protected int Price;
 
        // Срок годности.
        protected int WorkingLife;
 
        // Вывод информации о товаре.
        public virtual string Info()
        {
            return string.Format("Название продукта - {0}\nЦена - {1}", Name, Price);
        }
 
        // Соответствие сроку годности.
        public virtual bool IsTovarToWorkingLife(DateTime currentDate)
        {
            return (currentDate < ManufactureDate + new TimeSpan(WorkingLife, 0, 0, 0));
        }
    }
 
    // Продукт.
    class Product : Tovar
    {
        // Новый продукт.
        public Product(string name, int price, DateTime manufactureDate, int workingLife)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
            WorkingLife = workingLife;
        }
 
        public override string Info()
        {
            return base.Info() +
                   string.Format("\nДата производства - {0}\nСрок годности - {1} дней",
                                 ManufactureDate, WorkingLife);
        }
    }
 
    // Партия.
    class Batch : Tovar
    {
        private int count;
 
        // Новая партия.
        public Batch(string name, int price, int count, DateTime manufactureDate, int workingLife)
        {
            this.count = count;
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
            WorkingLife = workingLife;
        }
 
        public override string Info()
        {
            return base.Info() +
                   string.Format("\nКоличество - {0}\nДата производства - {1}\nСрок годности - {2} дней",
                                 count, ManufactureDate, WorkingLife);
        }
    }
 
    // Комплект.
    class Set : Tovar
    {
        private string list;
 
        // Новый комплект.
        public Set(string name, int price, string list)
        {
            this.list = list;
            Name = name;
            Price = price;
        }
 
        public override string Info()
        {
            return base.Info() +
                   string.Format("\nПеречень продуктов - {0}",
                                 list);
        }
 
        // Переопределяем, так как у комплекта бесконечный срок годности.
        public override bool IsTovarToWorkingLife(DateTime currentDate)
        {
            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Tovar> tovari = new List<Tovar>
            {
                new Product("Вечный хлеб", 100, Convert.ToDateTime("02.12.2010"), 999999),
                new Batch("Жареные тараканы", 3, 444, Convert.ToDateTime("05.12.2010"), 60),
                new Set("Шпоры по Высшей Математике", 2, "цветные, белые, прозрачные")
            };

            // Выводим данные и соответствие сроку годности.
            DateTime now = DateTime.Now;
            foreach (Tovar tovar in tovari)
            {
                Console.WriteLine(tovar.Info());
                Console.WriteLine(tovar.IsTovarToWorkingLife(now) ? "Годен" : "Не годен");
                Console.WriteLine("--------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
