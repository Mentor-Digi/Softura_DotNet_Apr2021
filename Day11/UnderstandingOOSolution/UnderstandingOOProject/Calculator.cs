using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Computer : Calculator //Derived class
    {
        public Computer()
        {
            Make = "IBM";
            Speed = 10001;
        }
        public override void DoWork()//Dynamic polymorphism - overriding
        {
            base.DoWork();
            Console.WriteLine("Does work");
        }
    }
    class Calculator//Base class
    {
        public string Make { get; set; }
        public int Speed { get; set; }
        public Calculator()
        {
            Make = "ABC Corp.";
            Speed = 101;
        }
        //public void Calculate()
        //{
        //    Console.WriteLine("Calculating....");
        //}
        public virtual void DoWork()
        {
            Console.WriteLine("Calculating....");
        }
        public void PrintCalculatorInfo()
        {
            Console.WriteLine("Make "+Make);
            Console.WriteLine("Speed "+Speed);
        }
    }

}
