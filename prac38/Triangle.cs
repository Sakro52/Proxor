using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac38
{
    internal class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Стороны не образуют треугольник.");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static Triangle Enter()
        {
            Console.Write("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону c: ");
            double c = double.Parse(Console.ReadLine());

            return new Triangle(a, b, c);
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Print()
        {
            Console.WriteLine($"Треугольник: a={a}, b={b}, c={c}");
            Console.WriteLine($"Периметр: {Perimeter():F2}, Площадь: {Area():F2}");
        }
    }
}