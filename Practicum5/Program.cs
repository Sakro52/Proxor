using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUBBU
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Console.Write("a=");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b=");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("c=");
            //double c = double.Parse(Console.ReadLine());
            //if (a < b + c && b < a + c && c < a + b)
            //{
            //    double p = (a + b + c) / 2;
            //    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //    Console.Write($"s={s:f2}");
            //    Console.Write(" сушествует");
            //}
            //else
            //{
            //    Console.Write("не сушествует");
            //}

            //Console.ReadLine();

            //Задача 2

            Console.WriteLine("ввод a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("ввод b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("ввод c=");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                Console.WriteLine($"ввыод 2 корня:x1{(-b + Math.Sqrt(d) / (2 * a))}, x2={(-b - Math.Sqrt(d) / (2 * a))}");

            }
            else if (b == 0)
            {
                Console.WriteLine($"Один корень:x={-b /(2 * a)}");
            }
            else
                Console.WriteLine("Корней нет"); 
        
            Console.ReadLine();


        }
    }
}
