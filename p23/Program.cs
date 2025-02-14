using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект с именем rec,конструктор без параметров
            Coco rec = new Coco();
            Console.WriteLine($"{rec.ToString()}\n");
            //конструктор с rec параметрами 
            Coco rec2 = new Coco(4, 3);
            Console.WriteLine($"{rec2.ToString()}\n");
            //конструктор с parse
            Console.WriteLine("Введите длину");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            double width = double.Parse(Console.ReadLine());
            Coco rec3 = new Coco(length, width);
            Console.WriteLine($"{rec3.ToString()}\n");
            Console.ReadLine();
        }
    }
}
