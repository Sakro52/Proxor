using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсачь
{
    class PrintingHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Newspaper> Newspapers { get; set; }

        public PrintingHouse()
        {
            Newspapers = new List<Newspaper>();
        }
    }
}