using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musicshop.BLL;
using Musicshop.Models;

namespace Musicshop.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryRepo catrepo = new CategoryRepo();
        public ActionResult GetAllcategories()
        {
            List<Category> categories = catrepo.GetAllCategories();

            return View(categories);
        }
    }
}