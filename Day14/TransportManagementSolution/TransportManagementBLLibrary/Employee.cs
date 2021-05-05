using System;
using System.Diagnostics.CodeAnalysis;

namespace TransportManagementBLLibrary
{
    public class Employee : IComparable<Employee>
    {
        const string DEFAULT_PASSWORD = "1234";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public Employee() {
            Password = DEFAULT_PASSWORD;
        }

        public Employee(int id, string name, string location, string phone)
        {
            Id = id;
            Name = name;
            Location = location;
            Phone = phone;
            Password = DEFAULT_PASSWORD;
        }

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Please enter the employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Phone Number");
            Phone= Console.ReadLine();
            Console.WriteLine("Please enter the employee Location");
            Location = Console.ReadLine();
        }
        public override string ToString()
        {
            string maskedPassword = GetMaskedPassword(Password);
            return "Employee Id : " + Id + " Name : " + Name + " Phone : " + Phone + " Location : " + Location + " Password : " + maskedPassword;
        }

        private string GetMaskedPassword(string password)
        {
            string result = password.Substring(0, 2);
            for (int i = 2; i < password.Length; i++)
            {
                result = result + "*";
            }
            return result;
        }

        public int CompareTo([AllowNull] Employee other)
        {
            return this.Location.CompareTo(other.Location);
        }
    }
}
