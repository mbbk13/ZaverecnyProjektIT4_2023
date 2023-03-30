using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        SqlRepository sqlRepository;
        public LoginForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void Login()
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                User user = sqlRepository.GetUser(tbUserName.Text);
                if (user != null)
                {
                    if (user.VerifyPassword(tbPassword.Text))
                    {
                        var role = sqlRepository.GetRole(user.Role);
                        if (role != null&&role.Name!="admin")
                        {
                            WorkHoursForm mainForm = new WorkHoursForm(false);
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            AdminMainForm mainForm = new AdminMainForm(user, this);
                            mainForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Heslo není správné!");
                    }
                }
                else
                {
                    MessageBox.Show("Uživatel neexistuje!");
                }
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }
    }
}
