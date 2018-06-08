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
                            user.Role = GetRoleById(reader.GetInt32(1)) as Role;
                            user.Name = reader.GetString(2);
                            user.Address = reader.GetString(3);
                            user.Zipcode = reader.GetString(4);
                            user.City = reader.GetString(5);
                            user.Email = email;
                            user.Password = password;
                        }
                    }
                    return user;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
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
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"INSERT INTO Users(name, address, zipcode, city, email, password) 
                                        VALUES (@Name, @Address, @Zipcode, @City, @Email, @Password)";
                    sqlCom.Parameters.Add("@Name", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Address", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Zipcode", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@City", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Email", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Password", SqlDbType.NChar);

                    sqlCom.Parameters["@Name"].Value = user.Name;
                    sqlCom.Parameters["@Address"].Value = user.Address;
                    sqlCom.Parameters["@Zipcode"].Value = user.Zipcode;
                    sqlCom.Parameters["@City"].Value = user.City;
                    sqlCom.Parameters["@Email"].Value = user.Email;
                    sqlCom.Parameters["@Password"].Value = user.Password;

                    connection.Open();
                    sqlCom.ExecuteNonQuery();
                    return "Succes";
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

        public bool UpdateUser(User user)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"UPDATE Users SET name=@Name, address=@Address, zipcode=@Zipcode, city=@City, email=@Email, password=@Password WHERE email=@Email AND password=@Password";
                    sqlCom.Parameters.Add("@Name", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Address", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Zipcode", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@City", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Email", SqlDbType.NChar);
                    sqlCom.Parameters.Add("@Password", SqlDbType.NChar);

                    sqlCom.Parameters["@Name"].Value = user.Name;
                    sqlCom.Parameters["@Address"].Value = user.Address;
                    sqlCom.Parameters["@Zipcode"].Value = user.Zipcode;
                    sqlCom.Parameters["@City"].Value = user.City;
                    sqlCom.Parameters["@Email"].Value = user.Email;
                    sqlCom.Parameters["@Password"].Value = user.Password;

                    connection.Open();
                    sqlCom.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool DeleteUser(User user)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"DELETE FROM Users WHERE email=@Email AND password=@Password";

                    sqlCom.Parameters.Add("@Email", SqlDbType.VarChar);
                    sqlCom.Parameters.Add("@Password", SqlDbType.VarChar);

                    sqlCom.Parameters["@Email"].Value = user.Email;
                    sqlCom.Parameters["@Password"].Value = user.Password;

                    connection.Open();
                    sqlCom.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
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
                    int roleid = 0;
                    string name = "Error";

                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM Roles WHERE roleid=@id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);

                    sqlCom.Parameters["@Id"].Value = id;

                    connection.Open();

                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roleid = reader.GetInt32(0);
                            name = reader.GetString(1);
                        }
                    }
                    Role role = new Role(roleid, name);
                    return role;
                }
                catch (Exception ex)
                {
                    return "error";
                }
            }
        }
    }
}