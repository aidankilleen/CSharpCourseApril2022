using NUnit.Framework;
using UserDaoLibrary;

namespace UserDaoLibraryTest
{
    public class Tests
    {
        UserDao dao;

        [SetUp]
        public void Setup()
        {
            dao = new UserDao();
        }

        [Test]
        public void Test1()
        {
             

            var user = dao.GetUser(5);

            Assert.NotNull(user);
        }
    }
}