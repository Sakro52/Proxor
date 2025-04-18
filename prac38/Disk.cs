using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac38
{
    internal class Disk : IShape
    {
        private double radius;

        public Disk(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным.");
            this.radius = radius;
        }

        public static Disk Enter()
        {
            Console.Write("Введите радиус: ");
            double r = double.Parse(Console.ReadLine());
            return new Disk(r);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public void Print()
        {
            Console.WriteLine($"Круг: радиус={radius}");
            Console.WriteLine($"Периметр: {Perimeter():F2}, Площадь: {Area():F2}");
        }
    }
}

