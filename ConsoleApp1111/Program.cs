using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1111
{
    class Program
    {
        public static int Max (int x, int y)
        {
            return x > y ? x : y;
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            Console.Write(Max (x,y));
            Console.ReadLine();
        }
    }
}
