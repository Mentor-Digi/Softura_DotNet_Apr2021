using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Controllers
{
    public class PostController : Controller
    {
        static List<Post> posts = new List<Post>()
        {
            new Post(){Id=101,PostText="Check the satus of movies on May 14th",Category="Film"},
            new Post(){Id=102,PostText="Alway wash hands with soap",Category="Health"},
            new Post(){Id=103,PostText="New arraivals!!! Rose Milk and Badam Milk",Category="Food"}
        };
        public IActionResult Index()
        {
            return View(posts);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post post)
        {
            posts.Add(post);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            int idx = posts.FindIndex(p => p.Id == id);
            return View(posts[idx]);
        }
        [HttpPost]
        public IActionResult Edit(int id,Post post)
        {
            int idx = posts.FindIndex(p => p.Id == id);
            posts[idx].PostText = post.PostText;
            posts[idx].Category = post.Category;
            return RedirectToAction("Index");
        }
    }
}
