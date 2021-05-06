using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TransportDALLibrary;

namespace TransportFEApplication
{
    class CompleteEmployee : Employee, IComparable<Employee>
    {
        const string INITIAL_PASSWORD = "1234";
        public int CompareTo([AllowNull] Employee other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public CompleteEmployee()
        {

        }
        public CompleteEmployee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Password = employee.Password;
            this.VehicleNumber = employee.VehicleNumber;
            this.Location = employee.Location;
            this.Phone = employee.Phone;
        }
        public void TakeEmployeeData()
        {
            Console.WriteLine("Please entrer the employee name");
            Name = Console.ReadLine();
            Console.WriteLine("Please entrer the employee location");
            Location = Console.ReadLine();
            Console.WriteLine("Please entrer the employee phone");
            Phone = Console.ReadLine();
            Password = INITIAL_PASSWORD;
        }
        public override string ToString()
        {
            string maskedPassword = GetMaskedPassword(Password);
            return "Id : " + Id + " Name : " + Name + " Location : " + Location + " Phone : " + Phone + " Password : " + maskedPassword;
        }

        private string GetMaskedPassword(string password)
        {
            string result = password.Substring(0, 2);
            for (int i = 2; i < password.Length; i++)
            {
                result += "*";
            }
            return result;
        }
    }
}
