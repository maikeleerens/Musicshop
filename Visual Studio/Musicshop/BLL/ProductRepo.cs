﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicshop.DAL;
using Musicshop.Models;

namespace Musicshop.BLL
{
    public class ProductRepo
    {
        ProductSQLContext context = new ProductSQLContext();

        public object GetProductById(int id)
        {            
            return context.GetProductById(id);
        }

        public List<Review> GetAllReviews(int id)
        {
            return context.GetAllReviews(id);
        }

        public string AddReview(Review review)
        {
            return context.AddReview(review);
        }
    }
}
