using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Musicshop.Models;

namespace Musicshop.DAL
{
    public class UserSQLContext
    {
        public object Login(string email, string password)
        {
            int resultUser;
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT userid FROM [Users] WHERE email=@email and password=@password", connection);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        resultUser = (int)cmd.ExecuteScalar();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        connection.Close();
                        return "Account Gegevens bestaan niet.";
                    }

                    User user = new User();
                    connection.Open();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM [Users] WHERE email = @email AND password = @password";
                    sqlCom.Parameters.Add("@email", SqlDbType.VarChar);
                    sqlCom.Parameters.Add("@password", SqlDbType.VarChar);
                    sqlCom.Parameters["@email"].Value = email;
                    sqlCom.Parameters["@password"].Value = password;                    
                    
                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Userid = reader.GetInt32(0);
                            user.Role = GetRoleById((int)reader["roleid"]) as Role;
                            user.Name = (string)reader["name"];
                            user.Address = (string)reader["address"];
                            user.Zipcode = (string)reader["zipcode"];
                            user.City = (string)reader["city"];
                            user.Email = (string)reader["email"];
                            user.Password = (string)reader["password"];
                        }
                    }
                    return user;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    connection.Close();
                    return "error";
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string Register(User user)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    dynamic procedure = "InsertUser";
                    SqlCommand sqlCom = new SqlCommand(procedure, connection);

                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.Add("@name", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@address", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@zipcode", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@city", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@email", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@password", SqlDbType.NChar);

                    sqlCom.Parameters["@name"].Value = user.Name;
                    sqlCom.Parameters["@address"].Value = user.Address;
                    sqlCom.Parameters["@zipcode"].Value = user.Zipcode;
                    sqlCom.Parameters["@city"].Value = user.City;
                    sqlCom.Parameters["@email"].Value = user.Email;
                    sqlCom.Parameters["@password"].Value = user.Password;

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

        public object GetUserById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    User user = new User();
                    connection.Open();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM [Users] WHERE userid = @id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);
                    sqlCom.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Userid = id;
                            user.Role = GetRoleById((int)reader["roleid"]) as Role;
                            user.Name = (string)reader["name"];
                            user.Address = (string)reader["address"];
                            user.Zipcode = (string)reader["zipcode"];
                            user.City = (string)reader["city"];
                            user.Email = (string)reader["email"];
                            user.Password = (string)reader["password"];
                        }
                    }
                    return user;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    connection.Close();
                    return "error";
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string EditUser(User user)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    dynamic procedure = "EditUser";
                    SqlCommand sqlCom = new SqlCommand(procedure, connection);

                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.Add("@name", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@address", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@zipcode", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@city", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@email", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);

                    sqlCom.Parameters["@name"].Value = user.Name;
                    sqlCom.Parameters["@address"].Value = user.Address;
                    sqlCom.Parameters["@zipcode"].Value = user.Zipcode;
                    sqlCom.Parameters["@city"].Value = user.City;
                    sqlCom.Parameters["@email"].Value = user.Email;
                    sqlCom.Parameters["@id"].Value = user.Userid;


                    connection.Open();
                    sqlCom.ExecuteNonQuery();
                    return "Success";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "Error";
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public object GetRoleById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    Role role = new Role();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM Roles WHERE roleid=@id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);

                    sqlCom.Parameters["@Id"].Value = id;

                    connection.Open();

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            role.Roleid = id;
                            role.Name = (string)reader["name"];
                        }
                    }
                    return role;
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
    }
}