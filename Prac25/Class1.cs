using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Edition
    {
        private string title;
        private string autor;
        private int yearofpublication;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Autor
        {
            get { return (autor != "") ? autor : "Неизвестно"; }
            set => autor = value;
        }
        public int Yearofpublication
        {
            get { return (yearofpublication != 0) ? yearofpublication : 0; }
            set
            {
                if (value >= 1990 && value <= 2024)
                    yearofpublication = value;
                else
                    yearofpublication = 0;


            }
        }
        public void Book()
        {
        }
        public Edition(string title, string autor, int yearofpublication)
        {
           this.Title = title;
           this.Autor = autor;
            this.Yearofpublication = yearofpublication;   
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Autor}");
            Console.WriteLine($"Год издания: {Yearofpublication}");
        }


        public void Change(int years)
        {
            int newYear = Yearofpublication + years;
            if (newYear >= 1990 && newYear <= 2024)
            {
                Yearofpublication = newYear;
            }
            else
            {
                Console.WriteLine("Ошибка: Новый год издания выходит за допустимый диапазон.");
            }
        }
        public string ToString(int startYear, int endYear)
        {
            if (Yearofpublication >= startYear && Yearofpublication <= endYear)
            {
                return $"Год издания {Yearofpublication} попадает в диапазон {startYear} - {endYear}.";
            }
            else
            {
                return $"Год издания {Yearofpublication} не попадает в диапазон {startYear} - {endYear}.";
            }

        }
        public override string ToString()
        {
            return $"Название: {Title}\nАвтор: {Autor}\nГод издания: {Yearofpublication}";
        }
    }
}
