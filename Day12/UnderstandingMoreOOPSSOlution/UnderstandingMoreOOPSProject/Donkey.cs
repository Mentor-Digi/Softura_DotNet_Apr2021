using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Donkey : Animal
    {
        public Donkey()
        {
            Console.WriteLine("Its a donkey");
        }
        public override void Move()
        {
            Console.WriteLine("tok....tok......tok......");
        }
    }
}
