using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserDaoLibrary;

namespace HelloWorldDotNetWebApp
{
    public partial class About : Page
    {
        private UserDao dao = new UserDao();

        protected void Page_Load(object sender, EventArgs e)
        {

            var users = dao.GetUsers();

            foreach (User user in users) {
                lstUsers.Items.Add(user.Name);
            }
        }
    }
}