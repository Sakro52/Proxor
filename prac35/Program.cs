using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                int i = 0;
                Console.WriteLine(@"Выберите нужное Вам действие:
                1. Добавить в список Художественная книга;
                2. Добавить в список Нехудожественная книга;
                3. Добавить в список Учебник;
                4. Вывести все Художественные книги из списка;
                5. Вывести все Нехудожественные книги из списка;
                6. Вывести все Учебники из списка;
                7. Выход.");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch (i)
                {
                    case 1: library.AddFictionBook(); break;
                    case 2: library.AddNonFictionBook(); break;
                    case 3: library.AddTextBook(); break;
                    case 4: Console.WriteLine("Художественная книга:"); library.GetAllFictionBook(); break;
                    case 5: Console.WriteLine("Нехудожественная книга:"); library.GetAllNonFictionBook(); break;
                    case 6: Console.WriteLine("Учебник:"); library.GetAllTextBook(); break;
                    case 7: return;
                    default: Console.WriteLine(""); break;
                }
                Console.ReadKey();
            }   
        }
    }
}
