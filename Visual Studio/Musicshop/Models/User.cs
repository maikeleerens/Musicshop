using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class User
    {
        public int Userid { get; set; }
        public Role Role { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
    }
}