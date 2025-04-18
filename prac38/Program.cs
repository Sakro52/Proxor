using prac38;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            bool flag = true;

            do
            {
                Console.Write("Введите тип фигуры (1 - треугольник, 2 - круг): ");
                string figureType = Console.ReadLine().ToLower();

                try
                {
                    switch (figureType)
                    {
                        case "1":
                            shapes.Add(Triangle.Enter());
                            break;
                        case "2":
                            shapes.Add(Disk.Enter());
                            break;
                        default:
                            Console.WriteLine("Неверный тип фигуры.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                Console.WriteLine("\nТекущий список фигур:");
                foreach (IShape shape in shapes)
                {
                    shape.Print();
                    Console.WriteLine();
                }

                Console.Write("Хотите добавить ещё фигуру? (y/n): ");
                flag = Console.ReadLine().ToLower() == "y";

            } while (flag);

            Console.WriteLine("Программа завершена.");
            Console.ReadKey();
        }
    }
}
