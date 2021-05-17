using LearningMVCProject.Models;
using LearningMVCProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningMVCProject.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IRepo<Author> _repo;

        public AuthorController(IRepo<Author> repo,ILogger<AuthorController> logger )
        {
            _logger = logger;
            _repo = repo;
        }
        public IActionResult Index()
        {
            List<Author> authors = _repo.GetAll().ToList(); 
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            _repo.Add(author);

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Author author = _repo.Get(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(int id,Author author)
        {
            _repo.Update(id, author);

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Author author = _repo.Get(id);
            return View(author);
        }
    }
}
