using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class ChangePasswordForm : Form
    {
        SqlRepository sqlRepository;
        public ChangePasswordForm()
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtChangePassword1.Text != ""&& txtChangePassword2.Text != ""&& txtChangePasswordUsername.Text != ""&&txtChangePasswordCurrentPassword.Text!="")
            {
                var user = sqlRepository.GetUser(txtChangePasswordUsername.Text);
                if(user != null)
                {
                    if (user.VerifyPassword(txtChangePasswordCurrentPassword.Text))
                    {
                        user.ChangePassword(txtChangePassword2.Text);
                        sqlRepository.ChangeUserPassword(user.Id, user.Password, user.PasswordSalt);
                        MessageBox.Show("Změna hesla proběhla úspěšně!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aktuální heslo se neshoduje!");
                    }
                }
                else
                {
                    MessageBox.Show("Takovýto uživatel není v naší databázi!");
                }
            }
        }
    }
}
