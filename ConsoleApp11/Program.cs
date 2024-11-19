using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        public static double Func(int x,int y)
        {
            return (Math.Sqrt(x) + x) / (Math.Sqrt(y) + y);
        }
        static void Main(string[] args)
        {
            double a = Func(5,7) + Func(12,8) + Func(19,2);
            Console.WriteLine($"a = {a}");
            Console.ReadLine();
        }
    }
}
