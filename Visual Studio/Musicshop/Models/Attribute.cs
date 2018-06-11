using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Attribute
    {
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public decimal Price { get; set; }
    }
}