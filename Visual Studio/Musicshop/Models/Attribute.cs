using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Attribute
    {
        private string name;
        private string value;

        public string Name { get { return name; } }
        public string Value { get { return value; } }

        public Attribute(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}