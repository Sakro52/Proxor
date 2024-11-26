using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов 
        /// (ввода аргументов, нахождения минимальной величины, вывода результата).
        public static int Min(int a, int b, int c)
        {
            return a < b ? (a < b ? a : c):(b < c ? b : c);
        }
            public static int Input(string message)
            {
                Console.Write(message);
                return int.Parse(Console.ReadLine());
            }
            public static void Output(int result)
            { Console.WriteLine(result); }
            static void Main(string[] args)
            {
                int a = Input("a=");
                int b = Input("b=");
                int c = Input("c=");
                int result = Min(a, b, c);
                Output(result);
                Console.ReadLine();
            }
        }
    }
  
