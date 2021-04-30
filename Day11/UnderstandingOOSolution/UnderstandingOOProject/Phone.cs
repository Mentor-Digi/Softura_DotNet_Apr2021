using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Phone
    {
        string ringToneName; //variable
        public string Color { get; set; }//property
        //public Phone() { }//default public empty constructor
        public Phone() {
            Console.WriteLine("Phone created");
        }
        public void CheckWorkPublic()
        {
            Console.WriteLine("Public method");
        }
        protected void CheckWorkProtected()
        {
            Console.WriteLine("Protected method");
        }
        internal void CheckWorkInternal()
        {
            Console.WriteLine("Internal Method");
        }
        private void CheckWorkPrivate()
        {
            Console.WriteLine("Private method");
        }
    }
}
