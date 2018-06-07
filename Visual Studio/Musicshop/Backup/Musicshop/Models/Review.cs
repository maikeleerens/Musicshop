using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Review
    {
        private User user;
        private Product product;
        private int rating;
        private string message;

        public User User { get { return user; } }
        public Product Product { get { return product; } }
        public int Rating { get { return rating; } }
        public string Message { get { return message; } }
    }
}