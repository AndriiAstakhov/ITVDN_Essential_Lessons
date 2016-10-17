using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Indexers
{
    class BaseClass
    {
        private string[] baseArray = null;

        // Конструктор
        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "Ноль";
            baseArray[1] = "Один";
            baseArray[2] = "Два";
        }

        public virtual string this[int index]
        {
            get
            {
                return baseArray[index];
            }
        }
    }
}
