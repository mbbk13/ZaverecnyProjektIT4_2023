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
    public partial class AdminUsersEdit : Form
    {
        SqlRepository sqlRepository;
        public int IdUser {get; set; }
        public AdminUsersControl ParentForm { get; set; }
        public AdminUsersEdit(int idUser, AdminUsersControl parent)
        {
            InitializeComponent();
            IdUser = idUser;
            sqlRepository = new SqlRepository();
            ParentForm = parent;
        }

        private void AdminUsersEdit_Load(object sender, EventArgs e)
        {
            var user = sqlRepository.GetUser(IdUser);
            txtAdminEditUsername.Text = user.UserName;
            var role= sqlRepository.GetRole(user.Role);
            cboRoles.Text = role.Name;
            var roles = sqlRepository.GetRoles();
            foreach(var r in roles)
            {
                cboRoles.Items.Add(r.Name);
            }
        }

        private void btnAdminEditOK_Click(object sender, EventArgs e)
        {
            if(cboRoles.Text != "" && txtAdminEditUsername.Text!="") {
                var role = sqlRepository.GetRole(cboRoles.Text);
                sqlRepository.UpdateUser(txtAdminEditUsername.Text,role.Id,IdUser);
                ParentForm.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nevyplnil jste všechna pole!");
            }
        }

        private void btnAdminEditResetPassword_Click(object sender, EventArgs e)
        {
            var user=sqlRepository.GetUser(IdUser);
            user.ResetPassword();
            sqlRepository.ResetUserPassword(IdUser,user.Password,user.PasswordSalt);
            ParentForm.LoadData();
            this.Close();
        }
    }
}
