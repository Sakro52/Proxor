using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prac35
{
    internal class Library
    {
        public List<FictionBook> fictionBooks = new List<FictionBook>();
        public List<NonFictionBook> nonFictionBooks = new List<NonFictionBook>();
        public List<TextBook> textBooks = new List<TextBook>();

        public void AddFictionBook()
        {
            string title = " ", autor = " ", genre = " ";
            int year = 0;
            double price = 0;
            Console.Write("Введите название: ");
            try
            {
                title = Console.ReadLine();
                Console.Write("Введите автора: ");
                autor = Console.ReadLine();
                Console.Write("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите цену: ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите жанр: ");
                genre = Console.ReadLine();
            }
            catch { }
            fictionBooks.Add(new FictionBook(title, autor, year, price, genre));
        }
        public void AddNonFictionBook()
        {
            string title = " ", autor = " ", subject = " ";
            int year = 0;
            double price = 0;
            Console.Write("Введите название: ");
            try
            {
                title = Console.ReadLine();
                Console.Write("Введите автора: ");
                autor = Console.ReadLine();
                Console.Write("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите цену: ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите объект: ");
                subject = Console.ReadLine();
            }
            catch { }
            nonFictionBooks.Add(new NonFictionBook(title, autor, year, price, subject));
        }
        public void AddTextBook()
        {
            string title = " ", autor = " ";
            int year = 0, gradeLevel = 0;
            double price = 0;
            Console.Write("Введите название: ");
            try
            {
                title = Console.ReadLine();
                Console.Write("Введите автора: ");
                autor = Console.ReadLine();
                Console.Write("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите цену: ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите объект: ");
                gradeLevel = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            textBooks.Add(new TextBook(title, autor, year, price, gradeLevel));
        }
        public void GetAllFictionBook()
        {
            foreach (FictionBook fictionbook in fictionBooks)
            {
                Console.WriteLine($"Цена: {fictionbook.Price}\tАвтор: {fictionbook.Autor}\tГод: {fictionbook.Year}\tНазвание: {fictionbook.Title}\tжанр:{fictionbook.Genre} ");
            }
        }
        public void GetAllNonFictionBook()
        {
            foreach (NonFictionBook nonfictionbook in nonFictionBooks)
            {
                Console.WriteLine($"Цена: {nonfictionbook.Price}\tАвтор: {nonfictionbook.Autor}\tГод: {nonfictionbook.Year}\tНазвание: {nonfictionbook.Title}\tжанр:{nonfictionbook.Subject} ");
            }
        }

            public void GetAllTextBook()
            {
            foreach (TextBook textbook in textBooks)
            {
                Console.WriteLine($"Цена: {textbook.Price}\tАвтор: {textbook.Autor}\tГод: {textbook.Year}\tНазвание: {textbook.Title}\tжанр:{textbook.GradeLevel} ");
            }
        }
    }
}
