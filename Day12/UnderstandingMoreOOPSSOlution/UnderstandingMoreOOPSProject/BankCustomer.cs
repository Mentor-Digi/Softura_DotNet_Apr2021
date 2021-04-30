using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class BankCustomer
    {
        public ICustomerManager MyManager { get; set; }
        public void VisitsBank()
        {
            Console.WriteLine("meets manager");
            MyManager.ResolveCustomerIssue();
        }
    }
}
