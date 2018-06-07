using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musicshop.BLL;
using Musicshop.Models;

namespace Musicshop.Controllers
{
    public class UserController : Controller
    {
        private UserRepo userrepo = new UserRepo();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User login)
        {
            var user = userrepo.Login(login.Email, login.Password);

            if (user is User)
            {
                Session["User"] = user;
                return RedirectToAction("Index", "Home");
            }
            string message = user.ToString();
            ViewBag.Message = message;
            return View();
        }
    }
}