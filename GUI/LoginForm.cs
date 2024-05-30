using ShipmentTracking.Data;
using ShipmentTracking.Security;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ShipmentTracking.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string username, string password)
        {
            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Username == username);

                if (user == null)
                {
                    return false;
                }

                var passwordHash = SecurityHelper.HashPassword(password, user.Salt);

                return user.PasswordHash == passwordHash;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTxtBox.Text;
            var password = passwordTxtBox.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }

        private void passwordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }
    }
}
