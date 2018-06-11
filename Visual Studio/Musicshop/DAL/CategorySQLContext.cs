using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Musicshop.Models;

namespace Musicshop.DAL
{
    public class CategorySQLContext
    {
        public List<Category> GetAllCategories()
        {
            var categories = new List<Category>();

            using (SqlConnection connection = Database.Connection)
            {
                connection.Open();
                SqlCommand sqlCom = connection.CreateCommand();

                sqlCom.CommandText = @"SELECT * FROM [Category]";

                using (SqlDataReader reader = sqlCom.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(CategoryFromReader(reader));
                    }
                }
                return categories;
            }
        }

        public Category CategoryFromReader(SqlDataReader reader)
        {
            Category category = new Category
            {
                CategoryId = (int)reader["categoryid"],
                Name = (string)reader["categoryname"]
            };

            return category;
        }
    }
}
