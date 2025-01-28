using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19
{
    public partial class Books
    {
        public void Info()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Объем в листах: {Pages}");
        }
    }
    public partial class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Books(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }
        static void Main(string[] args)
        {
            Books myBook = new Books("Война и мир", "Лев Толстой", 1869, 1225);

            myBook.Info();
            Console.ReadLine();
        }
    }
}
