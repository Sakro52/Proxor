using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac26
{
    using System;

    public class Person
    {
        private int age;

        
        private static int retirementAge;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int RetirementAge
        {
            get { return retirementAge; }
            set { retirementAge = value; }
        }

        public Person() { }

        public Person(int age, int retirementAge)
        {
            this.Age = age;
            this.RetirementAge = retirementAge;  
        }
      
        public string CheckAge()
        {
            if (age >= retirementAge)
            {
                return "На пенсии";
            }
            else
            {
                return $"До пенсии осталось {retirementAge - age} лет";
            }
        }

    
        public int RetirementAge1
        {
            get { return retirementAge; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    retirementAge = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение пенсионного возраста. Должно быть от 1 до 100 лет.");
                }
            }
        }

        
        public int GetAge()
        {
            return age;
        }

      
        public void SetAge(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Возраст не может быть отрицательным.");
            }
        }

      
        public static string CheckRetirementStatus(Person person)
        {
            if (person.age >= person.RetirementAge)
            {
                return "На пенсии";
            }
            else
            {
                return $"До пенсии осталось {person.RetirementAge - person.age} лет";
            }
        }
    }
}
