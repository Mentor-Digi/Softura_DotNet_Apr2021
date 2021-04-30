using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class CustomerRepo
    {
        Customer[] customers;//= new BankCustomer[5];
        public CustomerRepo()
        {
        }
        public CustomerRepo(int size)
        {
            customers = new Customer[size];
        }
        public void ReadCustomerData()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Customer();
                customers[i].TakeCustomerData();
            }
        }
        public void PrintAllCustomer()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
        void PrintMenu()
        {
            ReadCustomerData();
            Console.WriteLine("Options");
            int choice = 0;
            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Select what you want to do");
                Console.WriteLine("1. Print Customer details");
                Console.WriteLine("2. Search custoemr by ID");
                Console.WriteLine("3. Change Customer Phone");
                Console.WriteLine("4. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PrintAllCustomer();
                        break;
                    case 2:
                        PrintCustomer();
                        break;
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice!=4);
            
        }

        private void UpdateCustomer()
        {
            Console.WriteLine("Please enter the customer Id");
            int id = 0;
            //while (Int32.TryParse(Console.ReadLine(),out id)==false)
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry. Please try again");
            }
            Customer customer = GetCustomerByID(id);
            if (customer != null)
            {
                Console.WriteLine(customer);
                Console.WriteLine("Please enter the nuew phone number");
                string phone = Console.ReadLine();
                customer.Phone = phone;
            }
            else
                Console.WriteLine("No such customer");
        }

        private void PrintCustomer()
        {
            Console.WriteLine("Please enter the customer Id");
            int id = 0;
            //while (Int32.TryParse(Console.ReadLine(),out id)==false)
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry. Please try again");
            }
            Customer customer = GetCustomerByID(id);
            if(customer!=null)
                Console.WriteLine(customer);
            else
                Console.WriteLine("No such customer");
        }

        private Customer GetCustomerByID(int id)
        {
            Customer customer = null;
            for (int i = 0; i < customers.Length; i++)
            {
                if(customers[i].Id==id)
                {
                    customer = customers[i];
                    break;
                }
            }
            return customer;
        }

        static void Main(string[] a)
        {
            CustomerRepo repo = new CustomerRepo(3);
            repo.PrintMenu();
            Console.ReadKey();
        }
    }
}
