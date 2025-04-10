using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac35
{
    internal class FictionBook : Book
    {
        string genre;
        public string Genre { get => genre; set => genre = value; }

        public FictionBook(string title, string autor, int year, double price, string genre)
            :base(title,autor,year,price) 
        {
         Genre = genre;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Художественная книга:");
            Console.WriteLine($"название: {Title}\nавтор: {Autor} \nгод выпуска: {Year} \nцена: {Price} \nжанр: {Genre}");
        }



    }
}
