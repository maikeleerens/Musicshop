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
                    product.Totalrating = GetTotalRating(id);
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

        public List<Review> GetAllReviews(int id)
        {
            var reviews = new List<Review>();            

            using (SqlConnection connection = Database.Connection)
            {
                connection.Open();
                SqlCommand sqlCom = connection.CreateCommand();

                sqlCom.CommandText = @"SELECT * FROM [Reviews] WHERE productid = @id";
                sqlCom.Parameters.Add("@id", SqlDbType.Int);
                sqlCom.Parameters["@id"].Value = id;

                using (SqlDataReader reader = sqlCom.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reviews.Add(ReviewFromReader(reader));
                    }
                }
                return reviews;
            }
        }

        public decimal GetTotalRating(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    decimal rating = 0;
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT AVG(rating) FROM [Reviews] WHERE productid = @id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);
                    sqlCom.Parameters["@id"].Value = id;

                    connection.Open();

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rating = Convert.ToDecimal(reader[0]);
                        }
                    }
                    return rating;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string AddReview(Review review)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"INSERT INTO [Reviews](userid, productid, rating, reviewmessage, reviewdate) 
                                        VALUES (@Userid, @Productid, @Rating, @Reviewmessage, @Reviewdate)";
                    sqlCom.Parameters.Add("@Userid", SqlDbType.Int);
                    sqlCom.Parameters.Add("@Productid", SqlDbType.Int);
                    sqlCom.Parameters.Add("@Rating", SqlDbType.Int);
                    sqlCom.Parameters.Add("@Reviewmessage", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Reviewdate", SqlDbType.DateTime);

                    sqlCom.Parameters["@Userid"].Value = review.User.Userid;
                    sqlCom.Parameters["@Productid"].Value = review.Product.ProductId;
                    sqlCom.Parameters["@Rating"].Value = review.Rating;
                    sqlCom.Parameters["@Reviewmessage"].Value = review.Message;
                    sqlCom.Parameters["@Reviewdate"].Value = DateTime.Now;

                    connection.Open();
                    sqlCom.ExecuteNonQuery();
                    return "Success";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return "Error";
                }
                finally
                {
                    connection.Close();
                }
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
                Message = (string)reader["reviewmessage"],
                ReviewDate = (DateTime)reader["reviewdate"]
            };
            return review;
        }
    }
}
