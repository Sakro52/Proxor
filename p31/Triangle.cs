using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
    using System;

    class Triangle : Figure
    {
        double side1;
        double side2;
        double side3;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Side3 { get => side3; set => side3 = value; }


        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public override void Print()
        {
            Console.WriteLine("Название:" + Name + " Первая сторона:" + Side1 + " Вторая сторона:" + Side2 + " Третья сторона" + Side3);
        }

        public static Triangle Enter()
        {
            Console.Clear();
            Console.Write("Введите название фигуры: ");
            string name = Console.ReadLine();
            Console.Write("Введите первую сторону: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону: ");
            double side3 = double.Parse(Console.ReadLine());
            return new Triangle(name, side1, side2, side3);
        }
    }
}