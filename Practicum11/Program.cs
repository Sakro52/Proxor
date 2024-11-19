using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum11
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Дополнительный Метод
        /// </summary>
        /// <param name="x">x</param>
        /// <returns>ЗНАЧЕНИЕ ВЫРАЖЕНИЕ</returns>
        public static double Func(int x)
        {
            return (Math.Sqrt(x) + x) / 2;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine($"y={Func(5)+Func(12)+Func(19)}");
            Console.ReadLine();
        }
    }
}
