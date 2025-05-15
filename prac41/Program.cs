using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac41
{
    internal class Program
    {
        delegate double Nums(double a,double b);
        static double Least(double a, double b)
        {
            return a<b ? b : a;
        }
        static double Greatest(double a, double b)
        {
            return a>b ? b : a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите веществ число 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите веществ число 2: ");
            double b = double.Parse(Console.ReadLine());
            Nums numLeast = Least;
            Nums numGreat = Greatest;
            Console.WriteLine(numLeast(a, b));
            Console.WriteLine(numGreat(a, b));

        }
    }
}
