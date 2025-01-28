using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
            class Person
        {
            // Поля
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            // Конструктор
            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            // Метод вывода данных
            public void PrintInfo()
            {
                Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Возраст: {Age}");
            }
        }

        class Program
        {
            static void Main()
            {
                // Создание объекта
                Person person = new Person("Иван", "Иванов", 30);

                // Вывод информации
                person.PrintInfo();
            Console.ReadLine();
            }
        }
    }
