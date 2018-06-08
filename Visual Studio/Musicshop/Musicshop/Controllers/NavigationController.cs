using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musicshop.BLL;
using Musicshop.Models;

namespace Musicshop.Controllers
{
    public class NavigationController : Controller
    {
        private CategoryRepo catrepo = new CategoryRepo();
        public ActionResult GetMenuItem()
        {
            List<Category> categories = catrepo.GetAllCategories();

            IEnumerable<Category> menu = categories;

            return PartialView("_menu", menu);
        }
    }
}