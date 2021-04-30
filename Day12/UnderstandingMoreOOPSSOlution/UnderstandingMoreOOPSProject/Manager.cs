using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Manager:IManagerPersonal,ICustomerManager,IEmployeeManager
    {
        public void Eat()
        {
            Console.WriteLine("Food is everything");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzz");
        }
        public void ConductStaffMeeting()
        {
            Console.WriteLine("Conducts meeting..");
        }
        public void HandlesEmployees()
        {
            Console.WriteLine("All employees report to him");
        }
        public void ApproveLoan()
        {
            Console.WriteLine("Approves custoemr loans");
        }
        public void ResolveCustomerIssue()
        {
            Console.WriteLine("Listens to issues and resolves it");
        }
    }
}
