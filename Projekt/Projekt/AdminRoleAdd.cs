using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class AdminRoleAdd : Form
    {
        SqlRepository sqlRepository;
        private AdminRolesControl AdminRolesControl { get; set; }
        public AdminRoleAdd(AdminRolesControl adminRolesControl)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            AdminRolesControl= adminRolesControl;
        }

        private void btnAdminRoleAddOK_Click(object sender, EventArgs e)
        {
            if(txtAdminRoleAddName.Text!="")
            {
                try
                {
                    sqlRepository.AddRole(txtAdminRoleAddName.Text);
                    AdminRolesControl.LoadData();
                    Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("V systému již taková role existuje!");
                }
            }
            else
            {
                MessageBox.Show("Nezadal jste název nové role!");
            }
        }
    }
}
