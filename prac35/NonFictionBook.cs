using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac35
{
    internal class NonFictionBook : Book
    {
        string subject;
        public string Subject { get => subject; set => subject = value; }
        public NonFictionBook(string title, string autor, int year, double price, string subject)
           : base(title, autor, year, price)
        {
            Subject = subject;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Нехудожественная книга:");
            Console.WriteLine($"название: {Title}\nавтор: {Autor} \nгод выпуска: {Year} \nцена: {Price} \nобъект: {subject}");
        }
    }
}
