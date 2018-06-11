using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musicshop.BLL;
using Musicshop.Models;

namespace Musicshop.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Details()
        {
            return View();
        }
    }
}