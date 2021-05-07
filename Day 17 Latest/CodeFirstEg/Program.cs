using System;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEg
{
    class Program
    {
        //public static EFContext db = new EFContext();
        public static Product p = new Product();
        static void Main(string[] args)
        {
            //p = AcceptDetails();
            //AddProduct(p);
            Console.WriteLine("Enter the Id of the product which you want to update");
            int id = Convert.ToInt32(Console.ReadLine());
            UpdateProduct(id);
            DisplayProducts();
           
        }


        private static void DisplayProducts()
        {
            using (var db = new EFContext())
            {
                foreach (var item in db.Products)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        private static void AddProduct(Product p1)
        {
            using (var db = new EFContext())
            {
                db.Products.Add(p1);
                db.SaveChanges();
                Console.WriteLine("Record Added Successfully");
            }
        }

        private static Product GetProductByID(int id)
        {
            using (var db=new EFContext())
            {
                p=db.Products.Find(id);
            }
            return p;
        }
        private static void UpdateProduct(int id)
        {
            using (var db=new EFContext())
            {
                p = GetProductByID(id);
                Console.WriteLine(p.ToString());
                p=AcceptDetails();
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private static Product AcceptDetails()
        {
            Console.WriteLine("Enter product name, price and qty");
            p.PName = Console.ReadLine();
            p.Price = Convert.ToInt32(Console.ReadLine());
            p.Qty = Convert.ToInt32(Console.ReadLine());
            return p;
        }
    }
}
