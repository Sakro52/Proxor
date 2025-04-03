using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            bool flag = true;

            do
            {
                Console.Write("Введите тип фигуры (r - прямоугольник, s - квадрат, t - треугольник, c - круг): ");
                string figureType = Console.ReadLine();

                switch (figureType.ToLower())
                {
                    case "r":
                        figures.Add(Rectangle.Enter());
                        break;
                    case "s":
                        figures.Add(Square.Enter());
                        break;
                    case "t":
                        figures.Add(Triangle.Enter());
                        break;
                    case "c":
                        figures.Add(Circle.Enter());
                        break;
                    default:
                        Console.WriteLine("Неверный тип фигуры.");
                        break;
                }

                foreach (Figure figure in figures)
                {
                    figure.Print();
                    Console.WriteLine();
                }

             
                Console.Write("Хотите добавить еще фигуру? (y/n): ");
                flag = Console.ReadLine().ToLower() == "y";

            } while (flag);

            Console.WriteLine("Программа завершена.");
        }
    }
}
    

               