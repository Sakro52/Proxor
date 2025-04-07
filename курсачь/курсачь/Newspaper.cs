using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсачь
{
    class Newspaper
    {
        public string Name { get; set; }
        public string Index { get; set; }
        public string Editor { get; set; }
        public decimal Price { get; set; }

        public void Print()
        {
            Console.WriteLine($"Название: {Name}, Индекс: {Index}, Редактор: {Editor}, Цена: {Price} руб.");
        }
    }
}

