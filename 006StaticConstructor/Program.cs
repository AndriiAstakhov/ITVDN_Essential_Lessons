using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006StaticConstructor
{
    class Program
    {
        static void Main()
        {
            NonStaticClass instance = new NonStaticClass();
            instance.NonStaticMethod();

            NonStaticClass.Property = 2;
            Console.WriteLine(NonStaticClass.Property);

            NonStaticClass.Method();
            NonStaticClass.Method(3);

            Console.ReadKey();
        }
    }
}
