using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Controllers
{
    public class FirstController : Controller
    {
        int[] arr = { 12, 34, 5, 6, 89, 56, 90 };
        public IActionResult Index()
        {
            ViewData["Name"] = "Ramu";
            ViewData["Age"] = 21;
            ViewBag.CustomerPhone = "987654321";
            ViewBag.Price = 123.42;
            TempData["Post"] = "This is the post that i want to  post";//gfrom one view to another view
            //Once the tempdata once got will delete
            var numbers = arr.Where(num => num < 75);
            ViewData["scores"] = numbers;
            ViewBag.Scores = numbers;
            return View();
        }

        public IActionResult About()
        { 
            return View();
        }

        public IActionResult ShowPost()
        {
            Post post = new Post();
            post.Id = 101;
            post.PostText = "Check this out. test Post";
            post.Category = "Text";
            return View(post);
        }
        //public string Index()
        //{
        //    return "Hello from conroller";
        //}
    }
}
