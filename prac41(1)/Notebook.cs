using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prac41_1_
{
    struct Notebook
    {
        public string Model;
        public string Manufacturer;
        public double Price;
        public Notebook(string model, string manufacturer, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Цена: {Price}");
        }
    }
}
