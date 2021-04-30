using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal created");
        }
        public void Eat()
        {
            Console.WriteLine("Eat eat. munch munch");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzz");
        }
        public abstract void Move();
    }
}
