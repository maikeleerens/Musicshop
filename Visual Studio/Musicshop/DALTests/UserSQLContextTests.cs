using Microsoft.VisualStudio.TestTools.UnitTesting;
using Musicshop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicshop.Models;

namespace Musichop.DAL.Tests
{
    [TestClass()]
    public class UserSQLContextTests
    {
        User klant;
        UserSQLContext context;
        [TestInitialize]
        public void TestInitialize()
        {
            klant = new User();
            context = new UserSQLContext();
        }

        [TestMethod()]
        public void LoginTest()
        {
            klant = context.Login("test@test.com", "test") as User;
            Assert.AreEqual(6, Convert.ToInt32(klant.Userid));
        }
    }
}