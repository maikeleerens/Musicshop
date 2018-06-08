using System;
using System.Collections.Generic;
using Musicshop.DAL;
using Musicshop.Models;

namespace Musicshop.BLL
{
    public class CategoryRepo
    {
        private CategorySQLContext context = new CategorySQLContext();

        public List<Category> GetAllCategories()
        {
            return context.GetAllCategories();
        }
    }
}
