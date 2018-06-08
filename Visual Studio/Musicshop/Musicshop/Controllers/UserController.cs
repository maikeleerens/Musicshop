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
                Session["User"] = user as User;
                return RedirectToAction("Index", "Home");
            }
            string message = user.ToString();
            ViewBag.Message = message;
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User register)
        {
            string message = null;
            message = userrepo.Register(register);

            if (message == "Succes")
            {
                ViewBag.Message = "Account is succesvol aangemaakt!";
                Login(register);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Dit emailadres is al geregistreerd!";
                return View(register);
            }            
        }

        public ActionResult MyAccount()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }           
        }
    }
}