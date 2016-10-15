using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            for (int i = 0; i < 6; i++)
            {
                my[i] = string.Format("string {0}", i);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(my[i]);
            }

            Console.ReadKey();
        }
    }
}
