using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac13_3_
{
    internal class Program
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="args"></param>
     /// Задача 3. Найти s=min(a, b) + min(c, d), используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
     /// 
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static int Input(string messenger)
        {
            Console.Write(messenger);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");
            int s = Min (a,b) + Min (d,c);
            Console.WriteLine($"{s}");
            Console.ReadLine();
        }
    }
}
