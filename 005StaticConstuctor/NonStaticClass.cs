using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005StaticConstuctor
{
    class NonStaticClass
    {
        static readonly long readonlyField = 2;

        public static long ReadonlyField
        {
            get { return NonStaticClass.readonlyField; }
        }

        static NonStaticClass()
        {
            readonlyField = 1;
        }
    }
}
