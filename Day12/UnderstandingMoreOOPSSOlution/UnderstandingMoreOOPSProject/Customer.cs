using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public void TakeCustomerData()
        {
            Console.WriteLine("Please enter the customer Id");
            int id = 0;
            //while (Int32.TryParse(Console.ReadLine(),out id)==false)
            while (!Int32.TryParse(Console.ReadLine(),out id))
            {
                Console.WriteLine("Invalid entry. Please try again");
            }
            Id = id;
            Console.WriteLine("Please enter the customer name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the customer phone");
            Phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return "ID : " + Id + " Name : " + Name + " Phone : " + Phone;
        }
        
    }
}
