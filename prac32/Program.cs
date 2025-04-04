using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Goods> товары = new List<Goods>();

            товары.Add(new Products("Молоко", 50m, new DateTime(2025, 1, 1), new DateTime(2025, 4, 1)));
            товары.Add(new Party("Товары для дома", 500m, new DateTime(2025, 1, 1), new DateTime(2025, 5, 1), 10));
            товары.Add(new Set("Подарочный набор", 1500m, new DateTime(2025, 1, 1), new DateTime(2025, 6, 1),
                
                new List<Products>
                {
                new Products ("Чай", 200m, new DateTime(2025, 1, 1), new DateTime(2025, 4, 1)),
                new Products ("Кофе", 300m, new DateTime(2025, 1, 1), new DateTime(2025, 6, 1))
                }));


            foreach (var товар in товары)
            {
                товар.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Просроченные товары:");
            foreach (var товар in товары)
            {
                if (товар.Expired())
                {
                    товар.PrintInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
