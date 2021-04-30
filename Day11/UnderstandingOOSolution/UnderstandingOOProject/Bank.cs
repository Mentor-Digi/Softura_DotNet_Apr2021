using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    public class Bank
    {
        void UndersandingOperatorOverloading()
        {
            Account account1 = new Account("12345", 10000, "Ramu");
            //Account account2 = new Account("12346", 15000, "Somu");
            //Account account3 = account1 + account2;
            //Console.WriteLine("Operator overloaded");
            //account1.PrintAccountDetails();
            //account2.PrintAccountDetails();
            //Console.WriteLine("-------------------------");
            //account3.PrintAccountDetails();
            //int num1 = 100;
            //int num2 = 200;
            //int num3 = num1 + num2;
            Console.WriteLine("Printing the reffference");
            Console.WriteLine(account1);
        }
        void CreateAndCheck()
        {
            Account account = new Account();
            account.OpenAccount(12345, "123-3453-253");
            account = null;//removing the reff to the object
            Console.WriteLine(account.AccountNumber); 
        }
        static void Main(string[] a)
        {
            Bank bank = new Bank();
            //bank.CreateAndCheck();
            //new Bank().CreateAndCheck();//anon object-no ref
            //Account account2 = new Account("00000090123", 12345.22, "Ramu");
            //account2.PrintAccountDetails();
            ////GC.Collect();//Just to show. Do not have to do this
            //Console.WriteLine("Cehck");
            bank.UndersandingOperatorOverloading();
            Console.ReadKey();
        }
    }
}
