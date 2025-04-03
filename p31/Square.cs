using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
    using System;

    class Square : Figure
    {
        double side1;

        public double Side1 { get => side1; set => side1 = value; }

        public Square(string name, double side1) : base(name)
        {

            Side1 = side1;

        }

        public override double Area()
        {
            return Math.Pow(side1, 2);
        }

        public override double Perimeter()
        {
            return 4 * side1;
        }

        public override void Print()
        {
            Console.WriteLine("Название:" + Name + " Сторона:" + Side1);
        }

        public static Square Enter()
        {
            Console.Clear();
            Console.Write("Введите название фигуры: ");
            string name = Console.ReadLine();
            Console.Write("Введите сторону: ");
            double side1 = double.Parse(Console.ReadLine());
            return new Square(name, side1);
        }
    }
}
