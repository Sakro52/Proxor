using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edition book = new Edition("Гарри Поттер и философский камень", "Дж. К. Роулинг", 1997);


            Console.WriteLine(book.ToString());


            int startYear = 1990, endYear = 2024;
            book.ToString(startYear, endYear);
            Console.ReadKey();
        }
    }
}
