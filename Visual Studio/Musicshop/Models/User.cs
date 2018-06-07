using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class User
    {
        private int userid;
        private Role role;
        private string name;
        private string address;
        private string zipcode;
        private string city;
        private string email;
        private string password;

        public int Userid { get { return userid; } }
        public Role Role { get { return role; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public string Zipcode { get { return zipcode; } }
        public string City { get { return city; } }
        public string Email { get { return email; } }
        public string Password { get { return password; } }

        public User(Role role, string name, string address, string zipcode, string city, string email, string password)
        {
            this.role = role;
            this.name = name;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
            this.email = email;
            this.password = password;
        }
    }
}