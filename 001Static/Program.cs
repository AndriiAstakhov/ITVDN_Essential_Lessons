using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Static
{
    class Program
    {
        static void Main()
        {
            NonStaticClass instance1 = new NonStaticClass(1);
            NonStaticClass instance2 = new NonStaticClass(2);

            instance1.Method();
            instance2.Method();

            NonStaticClass.field = 1;

            instance1.Method();
            instance2.Method();

            Console.ReadKey(); 
        }
    }
}
