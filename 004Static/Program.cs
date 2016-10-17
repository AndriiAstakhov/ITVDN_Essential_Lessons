using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Static
{
    class Program
    {
        static void Main()
        {
            NonStaticClass.Property = 33;

            Console.WriteLine(NonStaticClass.Property);

            Console.ReadKey();
        }
    }
}
