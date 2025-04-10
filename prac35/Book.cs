using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac35
{
    abstract class Book
    {
        string title;
        string autor;
        int year;
        double price;

        public string Title { get => title; set => title = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }
        public Book() { }
        public Book(string title, string autor, int year, double price) 
        {
            Title = title;
            Autor = autor;
            Year = year;
            Price = price;
        }
        public abstract void PrintInfo();


    }
}
