using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Shoppingcart
    {
        private User user;
        private List<Product> productlist;

        public User User { get { return user; } }
        public List<Product> ProductList { get { return productlist; } }

        public Shoppingcart(User user)
        {
            this.user = user;
            productlist = new List<Product>();
        }
    }
}