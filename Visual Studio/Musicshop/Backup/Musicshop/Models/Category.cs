using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Category
    {
        private string name;

        public string Name { get { return name; } }

        public Category(string name)
        {
            this.name = name;
        }
    }
}