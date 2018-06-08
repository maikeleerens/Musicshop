using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Musicshop.BLL;
using Musicshop.Models;

namespace Musicshop.Controllers
{
    public class UserController : Controller
    {
        private UserRepo userrepo = new UserRepo();

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

            if (message == "Success")
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

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Index", "Home");
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

        [HttpGet]
        public ActionResult Edit()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var user = Session["User"] as User;
                return View(user);
            }
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                string message = "";
                message = userrepo.EditUser(user);

                if (message == "Success")
                {
                    User newUser = new User();
                    newUser = userrepo.GetUserById(user.Userid) as User;
                    LogOut();
                    Login(newUser);
                    ViewBag.Message = "Uw gegevens zijn bijgewerkt!";                    
                    return View(newUser);
                }
                else
                {
                    ViewBag.Message = "Er is een fout opgetreden!";
                    return View();
                }
            }            
        }
    }
}