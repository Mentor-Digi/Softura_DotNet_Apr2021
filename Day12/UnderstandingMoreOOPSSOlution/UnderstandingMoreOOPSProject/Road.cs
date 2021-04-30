using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Road
    {
        void AssignAnimal()
        {
            Animal animal = null;
            Console.WriteLine("Choose the animal Horse or Donkey"); 
            string choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "HORSE":
                    animal = new Horse();
                    break;
                case "DONKEY":
                    animal = new Donkey();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            PullCart(animal);
        }
        void PullCart(Animal animal)
        {
            animal.Eat();
            animal.Move();
            animal.Sleep();
        }
        //static void Main(string[] a)
        //{
        //    new Road().AssignAnimal();
        //    Console.ReadKey();
        //}
    }
}
