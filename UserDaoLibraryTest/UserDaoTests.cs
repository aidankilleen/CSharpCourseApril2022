using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UserDaoLibrary;

namespace UserDaoLibraryTest
{
    [TestClass]
    class UserDaoTests
    {
        [TestMethod]
        public void TestCreateNewUser()
        {
            UserDao dao = new UserDao();
            User newUser = new User(0, "NEW", "new.user@gmail.com", true);
            User addedUser = dao.AddUser(newUser);

            Assert.AreNotEqual(0, addedUser.Id);

            dao.Close();
        }



    }
}
