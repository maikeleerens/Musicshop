using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Brand
    {
        private string name;

        public string Name { get { return name; } }

        public Brand(string name)
        {
            this.name = name;
        }
    }
}