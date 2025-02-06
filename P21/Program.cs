using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        internal class Calculate
        {
            private double Number1;
            private double Number2;

            public Calculate()
            {
                Number1 = 0;
                Number2 = 0;
            }

            public Calculate(double value)
            {
                Number1 = value;
                Number2 = value;
            }

            public Calculate(double value1, double value2)
            {
                Number1 = value1;
                Number2 = value2;
            }

            public string GetInfo()
            {
                return $"Число 1: {number1}, Число 2: {number2}";
            }

            public double ProcessValues()
            {
                return Math.Sqrt(number1 * number2);
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    Calculate obj1 = new Calculate();
                    Console.WriteLine(obj1.GetInfo());
                    Console.WriteLine("Результат: " + obj1.ProcessValues());

                    Calculate obj2 = new Calculate(5);
                    Console.WriteLine(obj2.GetInfo());
                    Console.WriteLine("Результат: " + obj2.ProcessValues());

                    Console.Write("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Calculate obj3 = new Calculate(num1, num2);
                    Console.WriteLine(obj3.GetInfo());
                    Console.WriteLine("Результат: " + obj3.ProcessValues());

                    Console.ReadLine();
                }
            }
        }
    }
}
  
  