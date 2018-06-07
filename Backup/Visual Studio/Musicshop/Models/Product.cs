using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Product
    {
        private Subcategory subcategory;
        private Model model;
        private string name;
        private string description;
        private List<Attribute> attributelist;
        private int stock;
        private decimal baseprice;

        public Subcategory Subcategory { get { return subcategory; } }
        public Model Model { get { return model; } }
        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public List<Attribute> AttributeList { get { return attributelist; } }
        public int Stock { get { return stock; } }
        public decimal BasePrice { get { return baseprice; } }

        public Product(Subcategory subcategory, Model model, string name, string description, int stock, decimal baseprice)
        {
            this.subcategory = subcategory;
            this.model = model;
            this.name = name;
            this.description = description;
            this.stock = stock;
            this.baseprice = baseprice;
            attributelist = new List<Attribute>();
        }
    }
}