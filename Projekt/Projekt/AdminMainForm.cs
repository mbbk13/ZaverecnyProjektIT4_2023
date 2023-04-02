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
    public partial class AdminMainForm : Form
    {
        private User User { get; set; }
        private new Form Parent { get; set; }
        public AdminMainForm(User user, Form form)
        {
            InitializeComponent();
            User = user;
            Parent = form;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AdminUsersControl adminUsersControl= new AdminUsersControl();
            adminUsersControl.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Close();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AdminRolesControl adminRolesControl= new AdminRolesControl();
            adminRolesControl.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployeesControl adminEmployeesControl = new AdminEmployeesControl();
            adminEmployeesControl.ShowDialog();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            AdminContractControl adminContractControl = new AdminContractControl();
            adminContractControl.ShowDialog();
        }

        private void btnWorkHours_Click(object sender, EventArgs e)
        {
            WorkHoursForm workHoursForm = new WorkHoursForm(true,User.Id,this);
            workHoursForm.ShowDialog();
        }

        private void btnWorkType_Click(object sender, EventArgs e)
        {
            AdminWorkTypeControl adminWorkTypeControl = new AdminWorkTypeControl();
            adminWorkTypeControl.ShowDialog();
        }
    }
}
