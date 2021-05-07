using System;
using System.Collections.Generic;
using System.Text;
using EFCoreEg.SoftModel;

namespace EFCoreEg
{
    class EmpClient
    {
        public static SofturaContext db = new SofturaContext();
       public static SofturaEmp e = new SofturaEmp();
        public static void Main()
        {
            //e=AcceptData();
           // InsertData(e);
          //  Console.WriteLine("Record Added!!");
            Console.WriteLine("Enter the Employee ID you want to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            DeleteData(id);
            
        }
        private static void InsertData(SofturaEmp e1)
        {
            db.SofturaEmps.Add(e1);
            db.SaveChanges();

        }

        private static void DeleteData(int id)
        {
            
            e = db.SofturaEmps.Find(id);
            if (e == null)
            {
                Console.WriteLine("No such Employee Exists");
            }
            else
            {
                db.SofturaEmps.Remove(e);
                db.SaveChanges();
                Console.WriteLine("The Employee is Deleted Successfully");
            }

        }
        private static SofturaEmp AcceptData()
        {
            Console.WriteLine("Enter Empname, Age,Gender, Phno and Email");
            SofturaEmp e = new SofturaEmp();
            e.Ename = Console.ReadLine();
            e.Age= Convert.ToInt32(Console.ReadLine());
            e.Gender = Console.ReadLine();            
            e.Phno = Console.ReadLine();
            e.Email = Console.ReadLine();
            return e;
        }
    }
}
