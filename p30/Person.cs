using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p30
{
  
    public abstract class AClass
    {

        /// <summary>
        ///Обычный класс
        /// </summary>
        public void Methood1() 
        {
            Console.WriteLine("Оьычный метод Methood1 из а.к. AClass");
        
        }
        /// <summary>
        /// Вирт класс с имением Methood2()
        /// </summary>
        public virtual void Methood2() 
        {
            Console.WriteLine("Виртуальный метод MEthood2 из а.к. AClass");
        }
        /// <summary>
        /// Абстрактный класс с именем  Methood3-4()
        /// </summary>
        public abstract void Methood3(); 
        public abstract void Methood4();
        
    }
}
