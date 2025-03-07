using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    internal class Empolee : Person
    {
        private string compani;
        private string jop;


        public string Compani
        {
            get { return compani; }
            set { compani = value; }
        }

        public string Jop
        {
            get { return jop; }
            set { jop = value; }
        }
        public Empolee(string firstName, string surname, int age, string compani, string jop) : base(firstName, surname, age)
        {
            this.Compani = compani;
            this.Jop = jop;
        }
        new public void Output() 
        {
            Console.WriteLine($"{FirstName}\t{SurName}\t{Age}\t{Compani}\t{Jop}");
        }
    }

}






