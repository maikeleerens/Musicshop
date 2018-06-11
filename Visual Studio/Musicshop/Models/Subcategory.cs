using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Subcategory
    {
        public int SubcategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
    }
}