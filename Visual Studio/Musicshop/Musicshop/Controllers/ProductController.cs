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
        ProductRepo productrepo = new ProductRepo();
        public ActionResult Details(int id)
        {
            Product product = new Product();
            product = productrepo.GetProductById(id) as Product;
            return View(product);
        }

        public ActionResult GetReviews(int id)
        {
            List<Review> reviews = productrepo.GetAllReviews(id);

            IEnumerable<Review> list = reviews;

            return PartialView("_Reviews", list);
        }
    }
}