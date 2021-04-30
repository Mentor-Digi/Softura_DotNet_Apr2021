using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Horse : Animal
    {
        public Horse()
        {
            Console.WriteLine("And its a horse");
        }
        public override void Move()
        {
            Console.WriteLine("Tok tok tok tok tok...");
        }
    }
}
