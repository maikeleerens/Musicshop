using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Musicshop.Models;

namespace Musicshop.DAL
{
    public class ProductSQLContext
    {
        public object GetProductById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    Product product = new Product();
                    product.Model = new Model();
                    product.Subcategory = new Subcategory();                    

                    connection.Open();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM [Product] INNER JOIN Subcategory ON Product.subcategoryid = Subcategory.subcategoryid WHERE Product.productid = @id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);
                    sqlCom.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.ProductId = id;
                            product.Subcategory = GetSubcategoryById((int)reader["subcategoryid"]) as Subcategory;
                            product.Model = GetModelById((int)reader["modelid"]) as Model;
                            product.Name = (string)reader["productname"];
                            product.Description = (string)reader["description"];
                            product.BasePrice = (decimal)reader["baseprice"];
                        }
                    }                    
                    return GetProductAttributes(product);
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return "error";
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public object GetProductAttributes(Product product)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    product.AttributeList = new List<Models.Attribute>();

                    connection.Open();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM [ProductAttribute] INNER JOIN Attribute ON Attribute.attributeid = ProductAttribute.attributeid WHERE productid = @id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);
                    sqlCom.Parameters["@id"].Value = product.ProductId;

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.AttributeList.Add(new Models.Attribute {
                                AttributeId = (int)reader["attributeid"],
                                Name = (string)reader["attributename"],
                                Price = (decimal)reader["attributeprice"],
                                Value = (string)reader["value"]
                            });                           
                        }
                    }
                    return product;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return "error";
                }
            }
        }

        public object GetModelById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    Model model = new Model();
                    model.Brand = new Brand();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM Model INNER JOIN Brand on Model.brandid = Brand.brandid WHERE Model.modelid=@id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);

                    sqlCom.Parameters["@id"].Value = id;

                    connection.Open();

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ModelId = id;
                            model.Brand.BrandId = (int)reader["brandid"];
                            model.Brand.Name = (string)reader["brandname"];
                            model.Name = (string)reader["modelname"];
                        }
                    }
                    return model;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "error";
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public object GetSubcategoryById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    Subcategory subcat = new Subcategory();
                    subcat.Category = new Category();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM Subcategory INNER JOIN Category ON Subcategory.categoryid = Category.categoryid WHERE Subcategory.subcategoryid=@id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);

                    sqlCom.Parameters["@id"].Value = id;

                    connection.Open();

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subcat.SubcategoryId = id;
                            subcat.Name = (string)reader["subcategoryname"];
                            subcat.Category.CategoryId = (int)reader["categoryid"];
                            subcat.Category.Name = (string)reader["categoryname"];
                        }
                    }
                    return subcat;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "error";
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Review> GetAllReviewsForProduct(int id)
        {
            var categories = new List<Review>();            

            using (SqlConnection connection = Database.Connection)
            {
                connection.Open();
                SqlCommand sqlCom = connection.CreateCommand();

                sqlCom.CommandText = @"SELECT * FROM [Reviews] WHERE reviewid = @id";
                sqlCom.Parameters.Add("@id", SqlDbType.Int);
                sqlCom.Parameters["@id"].Value = id;

                using (SqlDataReader reader = sqlCom.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(ReviewFromReader(reader));
                    }
                }
                return categories;
            }
        }

        public Review ReviewFromReader(SqlDataReader reader)
        {
            UserSQLContext userContext = new UserSQLContext();
            Review review = new Review            
            {
                ReviewId = (int)reader["reviewid"],
                User = userContext.GetUserById((int)reader["userid"]) as User,
                Product = GetProductById((int)reader["productid"]) as Product,
                Rating = (int)reader["rating"],
                Message = (string)reader["reviewmessage"]
            };
            return review;
        }
    }
}
