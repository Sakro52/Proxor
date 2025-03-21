using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31
{
    class Program
    {
        static void Main()
        {
            List<PrintedPraducst> products = new List<PrintedPraducst>();
            Magazine magazine1 = new Magazine("Tech Mag", 5000, 2.5);
            Newspaper newspaper1 = new Newspaper("Daily News", 12, 0.1, 20000);
            products.Add(magazine1);
            products.Add(newspaper1);
            foreach (var product in products)
            {
                product.Print();
                Console.WriteLine($"Стоимость тиража: {product.Cost()}\n");
            }

            Console.WriteLine("Редактирование параметров:");
            magazine1.Circlation = 6000;
            magazine1.Price = 3.0;
            newspaper1.NumberOfPages = 14;
            newspaper1.CostPerPage = 0.12;
            foreach (var product in products)
            {
                product.Print();
                Console.WriteLine($"Стоимость тиража: {product.Cost()}\n");
            }
        }
    }
}



