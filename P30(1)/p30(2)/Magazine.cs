using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{

    public class Magazine : PrintedPraducst
    {
        private int circlation;
        private double price;
        public Magazine() { }
        public Magazine(string name, int circlation, double price) : base(name) { Circlation = circlation; Price = price; }

        public int Circlation { get => circlation; set => circlation = value; }
        public double Price { get => price; set => price = value; }
    
        public override void Print()
        {
            Console.WriteLine($"Журнал: {Name} Тираж: {Circlation} Цена: {Price} ");
        } 

        public override double Cost()
        {
            return Circlation * Price;
        }
        
    }

}

