using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p30
{
     class DerivedClass:AClass
    {
        /// <summary>
        ///Переопред вирт метод с именем Methood2
        /// </summary>
        public override void Methood2()
        {
            base.Methood2();
            Console.WriteLine("Метод с именем Methood2 из класса AClass реализовон класс DerviClass");
        }

        /// <summary>
        ///Переопред абстракт метод с именем Methood3
        /// </summary>
        public override void Methood3() 
        {
            Console.WriteLine("Метод с именем Methood3 из класса Aclass реализован в производ классе DeriveClass ");
        }
        /// <summary>
        ///Переопред абстракт метод с именем Methood4
        /// </summary>
        public override void Methood4()
        {
            Console.WriteLine("Метод с именем Methood4 из класса Aclass реализован в производ классе DeriveClass ");
        }
    }
}
