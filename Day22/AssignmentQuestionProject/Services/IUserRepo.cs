using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentQuestionProject.Services
{
    public interface IUserRepo<T>
    {
        bool Register(T t);
        bool Login(T t);
    }
}
