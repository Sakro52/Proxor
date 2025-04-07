using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсачь
{
    class PostOffice
    {
        public int Number { get; set; }
        public string Address { get; set; }
        public List<Newspaper> Newspapers { get; set; }

        public PostOffice()
        {
            Newspapers = new List<Newspaper>();
        }

        public void Print()
        {
            Console.WriteLine($"Отделение №{Number}, Адрес: {Address}");
            Console.WriteLine("Газеты:");
            foreach (Newspaper n in Newspapers)
            {
                Console.WriteLine($"- {n.Name}");
            }
        }
    }
}
