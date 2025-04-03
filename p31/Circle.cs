using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
    using System;

    class Circle : Figure
    {
        double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void Print()
        {
            Console.WriteLine("Радиус:" + radius);
        }

        public static Circle Enter()
        {
            Console.Clear();
            Console.Write("Введите название фигуры: ");
            string name = Console.ReadLine();
            Console.Write("Введите радиус: ");
            double radius = double.Parse(Console.ReadLine());
            return new Circle(name, radius);
        }
    }
}