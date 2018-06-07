using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Subcategory
    {
        private Category category;
        private string name;

        public Category Category { get { return category; } }
        public string Name { get { return name; } }

        public Subcategory(Category category, string name)
        {
            this.category = category;
            this.name = name;
        }
    }
}