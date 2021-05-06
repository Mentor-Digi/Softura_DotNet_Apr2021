using System;
using TransportBLLibrary;

namespace TransportFEApplication
{
    class Program
    {
        EmployeeLogin login;
        EmployeeManagement management;
        EmployeeBL bl;
        public Program()
        {
            bl = new EmployeeBL();
            login = new EmployeeLogin(bl);
            management = new EmployeeManagement(bl);
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Print all");
                Console.WriteLine("4. Sort and print all");
                Console.WriteLine("5. Update Password");
                Console.WriteLine("10. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        login.RegisterEmployee();
                        break;
                    case 2:
                        login.UserLogin();
                        break;
                    case 3:
                        management.PrintAllEmployee();
                        break;
                    case 4:
                        management.PrintEmployeesSortedById();
                        break;
                    case 5:
                        management.ResetPassword();
                        break;
                    case 10:
                        Console.WriteLine("Quiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again...");
                        break;
                }

            } while (choice !=10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().PrintMenu();
            Console.ReadKey();
        }
    }
}
