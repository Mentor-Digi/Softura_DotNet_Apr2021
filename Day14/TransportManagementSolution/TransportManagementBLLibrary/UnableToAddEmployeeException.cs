using System;
using System.Collections.Generic;
using System.Text;

namespace TransportManagementBLLibrary
{
    public class UnableToAddEmployeeException : ApplicationException
    {
        string _message;
        public UnableToAddEmployeeException()
        {
            _message = "Unable to add employee cos of ID duplication. Try again";
        }
        public override string Message => _message;
    }
}
