using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Static
{
    class NonStaticClass
    {
        static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
}
