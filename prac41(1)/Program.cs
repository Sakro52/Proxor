using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac41_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("ThinkPad X1", "Lenovo", 1500);
            Notebook notebook2 = new Notebook("MacBook Pro", "Apple", 2000);
            Notebook notebook3 = new Notebook("Pavilion", "HP", 1200);

            List<Notebook> notebooks = new List<Notebook> { notebook1, notebook2, notebook3 };

            foreach (var notebook in notebooks)
            {
                notebook.PrintInfo();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
