using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public Subcategory Subcategory { get; set; }
        public Model Model { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Attribute> AttributeList { get; set; }
        public int Stock { get; set; }
        public decimal BasePrice { get; set; }
    }
}