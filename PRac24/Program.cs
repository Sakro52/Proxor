using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto car1 = new Avto();
            car1.Print();

            Avto car2 = new Avto("Лада Жигули 4", "Синий", 70);

            car2.Print();
        
            Console.Write("Введите марку автомобиля: ");
            string brand = Console.ReadLine();
            Console.Write("Введите цвет автомобиля: ");
            string color = Console.ReadLine();
            Console.Write("Введите скорость автомобиля: ");
            double skor = double.Parse(Console.ReadLine());

            Avto car3 = new Avto(brand, color, skor);
            car3.Print();
            Console.Read();
        }
    }
}
