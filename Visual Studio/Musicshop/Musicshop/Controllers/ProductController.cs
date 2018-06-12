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

        [HttpGet]
        public ActionResult AddReview()
        {
            return PartialView("_AddReview");
        }

        [HttpPost]
        public ActionResult AddReview(Review review)
        {
            UserRepo userrepo = new UserRepo();
            review.User = userrepo.GetUserById(Convert.ToInt32(Request.Form["userid"])) as User;
            review.Product = productrepo.GetProductById(Convert.ToInt32(Request.Form["productid"])) as Product;
            review.Rating = Convert.ToInt32(Request.Form["rating"]);
            review.Message = Request.Form["message"].ToString();

            string message = null;
            message = productrepo.AddReview(review);

            if (message == "Success")
            {
                ViewBag.Message = "Bedankt voor uw feedback!";
                return View("Details");
            }
            else
            {
                ViewBag.Message = "Er is iets misgegaan!";
                return View("Details");
            }
        }
    }
}