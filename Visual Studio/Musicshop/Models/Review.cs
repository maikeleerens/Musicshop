using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public int Rating { get; set; }
        public string Message { get; set; }
    }
}