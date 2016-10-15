using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //Ковариантность массивов в C#.

    public interface IAnimal
    {
        void Voice();
    }

    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog()};

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.WriteLine(new string('-', 50));


            IAnimal[] animal = dogs; //Ковариантность.

            for (int i = 0; i < dogs.Length; i++)
            {
                animal[i].Voice();
                //animal[i].Jump();
            }

            Console.WriteLine(new string('-', 50));

            dogs = (Dog[])animal; //Не является Контрвариантностью.

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Jump();
                dogs[i].Voice();
            }

            //Delay
            Console.ReadKey();
        }
    }
}
