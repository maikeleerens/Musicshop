using System;
using System.Collections.Generic;
using Musicshop.DAL;
using Musicshop.Models;


namespace Musicshop.BLL
{
    public class UserRepo
    {
        private UserSQLContext context = new UserSQLContext();

        public object Login(string email, string password)
        {
            return context.Login(email, password);
        }

        public bool CreateUser(User user)
        {
            return context.CreateUser(user);
        }

        public bool UpdateUser(User user)
        {
            return context.UpdateUser(user);
        }

        public bool DeleteUser(User user)
        {
            return context.DeleteUser(user);
        }

        public object GetRoleById(int id)
        {
            return context.GetRoleById(id);
        }
    }
}