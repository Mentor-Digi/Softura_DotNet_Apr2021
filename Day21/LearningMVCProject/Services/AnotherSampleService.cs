using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningMVCProject.Services
{
    public class AnotherSampleService : ISample
    {
        public string Check()
        {
            return "Success from sub";
        }
    }
}
