using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prac35
{
    internal class TextBook : Book
    {
        int gradeLevel;
        public int GradeLevel { get => gradeLevel; set => gradeLevel = value; }
        public TextBook(string title, string autor, int year, double price, int gradeLevel)
          : base(title, autor, year, price)
        {
            GradeLevel = gradeLevel;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Учебник:");
            Console.WriteLine($"название: {Title}\nавтор: {Autor} \nгод выпуска: {Year} \nцена: {Price} \nуровень обучения: {GradeLevel}");
        }
    }
}
