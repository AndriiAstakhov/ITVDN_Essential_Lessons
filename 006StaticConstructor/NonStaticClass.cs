using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006StaticConstructor
{
    class NonStaticClass
    {
        private static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }

        static NonStaticClass()
        {
            Console.WriteLine("Статический конструктор - NonStaticClass");
            field = 1;
        }

        public static void Method()
        {
            Console.WriteLine("Статический метод, нестатического NonStaticClass");
        }

        public static void Method(int s)
        {
            Console.WriteLine("Перегруженный статический метод, нестатического NonStaticClass" + s);
        }

        public void NonStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
