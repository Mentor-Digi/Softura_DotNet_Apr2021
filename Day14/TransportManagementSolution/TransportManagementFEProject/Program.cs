using System;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    class Program
    {
        EmployeeLogin login;
        EmployeeRepo employeeRepo;
        EmployeeCRUD employeeCRUD;
        public Program()
        {
            employeeRepo = new EmployeeRepo();
            login = new EmployeeLogin(employeeRepo);
            employeeCRUD = new EmployeeCRUD(employeeRepo);
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("2. Print Employees");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        login.Login();
                        break;
                    case 2:
                        login.Register();
                        break;
                    case 3:
                        employeeCRUD.PrintAllEmployees();
                        break;
                    case 4:
                        Console.WriteLine("Exiting......");
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }

            } while (choice!=4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().PrintMenu();
            Console.ReadKey();
        }
    }
}
