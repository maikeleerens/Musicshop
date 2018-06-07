using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicshop.Models
{
    public class Role
    {
        private int roleid;
        private string name;

        public int Roleid { get { return roleid; } }
        public string Name { get { return name; } }

        public Role(int roleid, string name)
        {
            this.roleid = roleid;
            this.name = name;
        }
    }
}