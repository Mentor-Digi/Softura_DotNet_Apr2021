using LearningMVCProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningMVCProject.Controllers
{
    public class SampleController : Controller
    {
        private ISample _service;

        public SampleController(ISample service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            ViewBag.Message =  _service.Check();
            return View();
        }
    }
}
