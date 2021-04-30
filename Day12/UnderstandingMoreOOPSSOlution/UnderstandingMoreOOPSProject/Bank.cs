using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Bank
    {
        Manager manager;
        public void Routine()
        {
            manager = new Manager();
            BankCustomer customer = new BankCustomer();
            customer.MyManager = manager;
            customer.VisitsBank();
        }
        //static void Main(String[] a)
        //{
        //    Bank icici = new Bank();
        //    icici.Routine();
        //    Console.ReadKey();
        //}
    }
}
