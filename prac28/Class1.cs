using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    internal class Person
    {
        private string firstName;
        private string surName;
        private int age;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person() { }
        public Person(string name, string surname, int age)
        {
            this.firstName = name;
            this.surName = surname;
            this.age = age;
        }
        public void Output()
        {
            Console.WriteLine($"Name:\t{FirstName}\t{SurName}\t{Age}");
        }
      
    }
}
