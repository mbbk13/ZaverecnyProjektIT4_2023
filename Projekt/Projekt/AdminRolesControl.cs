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
    public partial class AdminRolesControl : Form
    {
        SqlRepository sqlRepository;
        public AdminRolesControl()
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
        }

        public void LoadData()
        {
            lvAdminRolesControl.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
            {
                lvAdminRolesControl.Items.Add(new ListViewItem(new string[] { role.Name,role.Id.ToString()}));
            }
        }

        private void AdminRolesControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdminRoleEdit_Click(object sender, EventArgs e)
        {
            if(lvAdminRolesControl.SelectedItems.Count > 0)
            {
                AdminRoleEdit adminRoleEdit = new AdminRoleEdit(Convert.ToInt32(lvAdminRolesControl.SelectedItems[0].SubItems[1].Text),this);
                adminRoleEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný záznam!");
            }
        }

        private void btnAdminRoleAdd_Click(object sender, EventArgs e)
        {
            AdminRoleAdd adminRoleAdd = new AdminRoleAdd(this);
            adminRoleAdd.ShowDialog();
        }

        private void btnAdminRoleDelete_Click(object sender, EventArgs e)
        {
            if (lvAdminRolesControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteRole(Convert.ToInt32(lvAdminRolesControl.SelectedItems[0].SubItems[1].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nevybral jste žádnou roli!");
            }
        }
    }
}
