using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class UnderstandingQueue
    {
        Queue<string> myQueue;
        public UnderstandingQueue()
        {
            myQueue = new Queue<string>();
        }
        void AddtoQueue()
        {
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("Hi");
            myQueue.Enqueue("Welcome");
            myQueue.Enqueue("Done");
        }
        void PrintQueue()
        {
            while (myQueue.Count>0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }
        //static void Main(string[] a)
        //{
        //    UnderstandingQueue understandingQueue = new UnderstandingQueue();
        //    understandingQueue.AddtoQueue();
        //    understandingQueue.PrintQueue();
        //    Console.ReadKey();
        //}
    }
}
