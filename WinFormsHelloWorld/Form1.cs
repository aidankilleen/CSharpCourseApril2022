using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDaoLibrary;

namespace WinFormsHelloWorld
{
    public partial class Form1 : Form
    {

        private UserDao dao = new UserDao();

        public Form1()
        {
            InitializeComponent();
            

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed the button");
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            User selectedUser = (User)lstUsers.SelectedItem;

            if (selectedUser != null)
            {
                txtId.Text = $"{ selectedUser.Id }";
                txtName.Text = selectedUser.Name;
                txtEmail.Text = selectedUser.Email;
                chkActive.Checked = selectedUser.Active;
            } else
            {
                txtId.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                chkActive.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<User> users = dao.GetUsers();

            foreach(User user in users)
            {
                lstUsers.Items.Add(user);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lstUsers.SelectedItem;

            DialogResult res = MessageBox.Show("Are you sure?", $"Delete user { selectedUser.Id }", MessageBoxButtons.OKCancel);

            if (res.Equals(DialogResult.OK))
            {
                dao.DeleteUser(selectedUser.Id);

                // remove this item from the list box
                lstUsers.Items.Remove(selectedUser);

            }
        }
    }
}
