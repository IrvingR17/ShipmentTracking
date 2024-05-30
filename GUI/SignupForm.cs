using ShipmentTracking.Data;
using ShipmentTracking.Entities;
using ShipmentTracking.Security;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ShipmentTracking.GUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTxtBox.Text;
            var password = passwordTxtBox.Text;
            var confirmPassword = confirmPasswordTxtBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                if (context.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("El nombre de usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var salt = SecurityHelper.GenerateSalt();
                var hashedPassword = SecurityHelper.HashPassword(password, salt);

                var user = new User
                {
                    Username = username,
                    PasswordHash = hashedPassword,
                    Salt = salt
                };

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void ClearFields()
        {
            usernameTxtBox.Text = "";
            passwordTxtBox.Text = "";
            confirmPasswordTxtBox.Text = "";
        }
    }
}
