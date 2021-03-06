using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserDaoLibrary;

namespace UserDaoLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserDao dao = new UserDao();
            Assert.IsNotNull(dao);
            dao.Close();
        }

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
