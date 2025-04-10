using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34._2
{
    internal class Garrage
    {
        public List<Lorry> lorries = new List<Lorry>();
        public List<Car> cars = new List<Car>();
        public List<Bicycle> bicycles = new List<Bicycle>();
        public void AddLorry()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxCapacity = 0;
            Console.Write("Введите цену: ");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите максимальную скорость: ");
                maxspeed = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите грузоподьемность: ");
                MaxCapacity = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            lorries.Add(new Lorry(prise, maxspeed, year, MaxCapacity));
        }
             public void AddCar()
            {
                int prise = 0, maxspeed = 0, year = 0, Power = 0;
                Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите максимальную скорость");
                maxspeed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год:");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите мощность:");
                Power = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
                cars.Add(new Car(prise, maxspeed, year, Power));
            }
        public void AddBicycle()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxPassengers = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость");
                maxspeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год:");
                year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество пасажиров:");
                MaxPassengers = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            bicycles.Add(new Bicycle(prise, maxspeed, year, MaxPassengers));
        }
        public void GetAllLorry()
        {
            foreach (Lorry lorry in lorries)
            {
                Console.WriteLine($"Цена: {lorry.Price}\tМаксимальная скорость: {lorry.Maxspeed}\tГод: {lorry.Year}\tМаксимальная грузоподьемность: {lorry.MaxCapacity}");
            }
        }

        public void GetAllCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"Цена: {car.Price}\tМаксимальная скорость: {car.Maxspeed}\tГод: {car.Year}\tМощность: {car.Power}");
            }
        }
        public void GetAllBicycle()
        {
            foreach (Bicycle bicycle in bicycles)
            {
                Console.WriteLine($"Цена: {bicycle.Price}\tМаксимальная скорость: {bicycle.Maxspeed}\tГод: {bicycle.Year}\tМаксимум пасажиров: {bicycle.MaxPassengers}");
            }
        }
    }
}
    

