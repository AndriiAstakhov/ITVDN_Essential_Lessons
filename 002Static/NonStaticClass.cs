using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Static
{
    class NonStaticClass
    {
        private int id;

        public NonStaticClass(int id)
        {
            this.id = id;
        }

        public static void Method()
        {
            //Console.WriteLine("Instance.Id = {0}", id);
            Console.WriteLine("В статических методах нельзя обращаться к нестатическим полям.");
        }
    }
}
