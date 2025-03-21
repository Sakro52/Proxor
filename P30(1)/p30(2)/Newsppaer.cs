using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
    public class Newspaper : PrintedPraducst
    {
        private int numberOfPages;
        private double costPerPage;
        private int circulation;


        public Newspaper(string name, int numberOfPages, double costPerPage, int circulation) : base(name)
        {
            NumberOfPages = numberOfPages;
            CostPerPage = costPerPage;
            Circulation = circulation;
        }


        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        public double CostPerPage
        {
            get { return costPerPage; }
            set { costPerPage = value; }
        }

        public int Circulation
        {
            get { return circulation; }
            set { circulation = value; }
        }


        public override void Print()
        {
            Console.WriteLine($"Газета: {Name}, Количество страниц: {NumberOfPages}, Стоимость листа: {CostPerPage}, Тираж: {Circulation}");
        }

        public override double Cost()
        {
            return NumberOfPages * CostPerPage * Circulation;
        }
    }
}

