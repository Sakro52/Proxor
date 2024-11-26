using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicu_
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        ///Задача 1.Найти минимальную величину из двух целых переменных a, b, используя вспомогательные методы
        //(ввода аргументов, нахождения минимальной величины, вывода результата).
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x =int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y =int.Parse(Console.ReadLine());
            Console.WriteLine($"{Min(x,y)}");
            Console.ReadLine();
            



        }
    }
}
