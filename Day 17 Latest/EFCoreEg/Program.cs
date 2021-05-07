using System;
using EFCoreEg.OrgModel;
using System.Linq;

namespace EFCoreEg
{
    class Program
    {
       public static OrganizationContext db = new OrganizationContext();

        static void Main(string[] args)
        {
            
            Empl e = AcceptData();
            InsertData(e);
            Console.WriteLine("Record Added Successfully");
            SelectData();
        }

        private static void SelectData()
        {
            var result = db.Empls.ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Newcity);
            }
        }

        private static void InsertData(Empl e1)
        {
            db.Empls.Add(e1);
            db.SaveChanges();

        }

        private static Empl AcceptData()
        {
            Console.WriteLine("Enter Empid, Empname, Gender, city and Deptid");
            Empl e = new Empl();
            e.Empid = Convert.ToInt32(Console.ReadLine());
            e.Name = Console.ReadLine();
            e.Gender = Console.ReadLine();
            e.Newcity = Console.ReadLine();
            e.Deptid = Convert.ToInt32(Console.ReadLine());
            return e;
        }
    }
}
