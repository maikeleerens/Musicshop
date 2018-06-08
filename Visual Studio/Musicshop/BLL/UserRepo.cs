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

        public string Register(User user)
        {
            return context.Register(user);
        }

        public object GetUserById(int id)
        {
            return context.GetUserById(id);
        }

        public string EditUser(User user)
        {
            return context.EditUser(user);
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