using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    internal class Calculate
    {
        
        /// <summary>
        /// Объявление полей
        /// </summary>
        private double field1;
        private double field2;

        public double Field1 { get => field1; set { if (value < 0) throw new ArgumentException("Error");field1 = value; } }
        public double Field2 { get => field2; set { if (value < 0) throw new ArgumentException("Error");field2 = value; } }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Calculate() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="field1"></param>
        
        public Calculate(double field1)
        {
            this.Field1 = field1;

        }
        /// <summary>
        ///  Конструктор с 2 параметрами
        /// </summary>
        /// <param name="field1"></param>
        /// <param name="field2"></param>
        public Calculate(double field1, double field2) : this(field1)
        {
            this.Field2 = field2;
        }
        /// <summary>
        /// Функция формирования строки с информацией об объекте
        /// </summary>
        //public void Output()
        //{
        //    Console.WriteLine($"field1 = {field1}, field2 = {field2}");
        //}
        public override string ToString()
        {
            return $"field1 = {Field1}, field2 = {Field2}";
        }
        /// <summary>
        ///  Функция вычисления квадратного поля
        /// </summary>
        /// <returns>field1,field2</returns>
        public double CalculateSquareRoot()
        {
            return Math.Sqrt(Field1 * Field2);
        }


    }
}
