using System;
using System.Collections.Generic;
using Musicshop.Models;

namespace Musicshop.DAL
{
    public interface IUserContext
    {
        object Login(string email, string password);

        bool CreateUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(User user);

        object GetRoleById(int id);
    }
}
