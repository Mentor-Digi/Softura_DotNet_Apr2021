using AssignmentQuestionProject.Models;
using AssignmentQuestionProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentQuestionProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepo<UserModel> _repo;

        public UserController(IUserRepo<UserModel> repo)
        {
            _repo = repo;
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserModel user)
        {
            try
            {
                _repo.Register(user);
                TempData["un"] = user.Username;
                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Login
        public ActionResult Login()
        {
            if (TempData.Count ==0)
                return View();
            UserModel user = new UserModel();
            user.Username = TempData.Peek("un").ToString();
            return View(user);

        }
        // POST: UserController/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel user)
        {
            try
            {
               if(_repo.Login(user))
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
