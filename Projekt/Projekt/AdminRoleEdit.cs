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
    public partial class AdminRoleEdit : Form
    {
        SqlRepository sqlRepository;
        private int IdRole { get; set; }
        private AdminRolesControl AdminRolesControl { get; set; }
        public AdminRoleEdit(int idRole, AdminRolesControl adminRolesControl)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            IdRole = idRole;
            AdminRolesControl = adminRolesControl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdminRoleEditName.Text != "")
            {
                sqlRepository.UpdateRole(IdRole,txtAdminRoleEditName.Text);
                AdminRolesControl.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("Nezadal jste nové jméno role!");
            }
        }

        private void AdminRoleEdit_Load(object sender, EventArgs e)
        {
            var role=sqlRepository.GetRole(IdRole);
            if (role != null)
            {
                txtAdminRoleEditName.Text = role.Name;
            }
            else
            {
                MessageBox.Show("Taková role neexistuje!");
            }
        }
    }
}
