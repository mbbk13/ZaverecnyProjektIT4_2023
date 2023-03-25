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
    public partial class AdminUsersControl : Form
    {
        SqlRepository sqlRepository;

        public AdminUsersControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvAdminUsersControl.Items.Clear();
            var users = sqlRepository.GetUsers();
            foreach (var user in users)
            {
                var employee = sqlRepository.GetEmployee(user.IdEmployee);
                var role = sqlRepository.GetRole(user.Role);
                lvAdminUsersControl.Items.Add(new ListViewItem(new string[] { employee.FirstName + " " + employee.LastName, user.UserName,user.Id.ToString(),role.Name.ToString()}));
            }
        }

        private void AdminUsersControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdminEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvAdminUsersControl.SelectedItems[0].SubItems[2].Text);
            if (lvAdminUsersControl.SelectedItems[0].SubItems[2].Text!=null)
            {
                var id = Convert.ToInt32(lvAdminUsersControl.SelectedItems[0].SubItems[2].Text);
                AdminUserEdit adminUsersEdit = new AdminUserEdit(id, this);
                adminUsersEdit.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný uživatel!");
            }
        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            AdminUserAdd adminUserAdd = new AdminUserAdd(this);
            adminUserAdd.ShowDialog();
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            if (lvAdminUsersControl.SelectedItems[0].SubItems[2].Text != null)
            {
                sqlRepository.DeleteUser(Convert.ToInt32(lvAdminUsersControl.SelectedItems[0].SubItems[2].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný uživatel!");
            }
        }
    }
}
