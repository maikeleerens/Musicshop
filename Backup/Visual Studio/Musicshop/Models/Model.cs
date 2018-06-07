using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Model
    {
        private Brand brand;
        private string name;

        public Brand Brand { get { return brand; } }
        public string Name { get { return name; } }

        public Model(Brand brand, string name)
        {
            this.brand = brand;
            this.name = name;
        }
    }
}