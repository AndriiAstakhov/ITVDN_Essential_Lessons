using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MyClass
    {
        private int[] array = new int[6];

        //Индексатор
        public int this[int index]
        {
            get //Аксесор
            {
                return array[index];
            }

            set //Мутатор
            {
                array[index] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            my[0] = 0;
            my[1] = 1;
            my[2] = 2;
            my[3] = 3;
            my[4] = 4;
            my[5] = 5;

            Console.WriteLine(my[0]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            Console.WriteLine(my[3]);
            Console.WriteLine(my[4]);
            Console.WriteLine(my[5]);

            Console.ReadKey();
        }
    }
}
