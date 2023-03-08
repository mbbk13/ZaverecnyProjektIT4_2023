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

        private void LoadData()
        {
            var users = sqlRepository.GetUsers();
            foreach (var user in users)
            {
                var employee = sqlRepository.GetEmployee(user.IdEmployee);
                lvAdminUsersControl.Items.Add(new ListViewItem(new string[] { employee.FirstName + " " + employee.LastName, user.UserName }));
            }
        }

        private void AdminUsersControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdminEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
