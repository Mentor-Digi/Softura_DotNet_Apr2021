using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningMVCProject.Services
{
    public class SampleService:ISample
    {
        public string Check()
        {
            return "Good";
        }
    }
}
