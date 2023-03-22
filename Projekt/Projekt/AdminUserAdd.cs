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
    public partial class AdminUserAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminUserAdd()
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
        }

        private void AdminUserAdd_Load(object sender, EventArgs e)
        {
            cboEmployees.Items.Clear();
            var employees = sqlRepository.GetEmployees();
            foreach ( var employee in employees )
            {
                if(!sqlRepository.IsUsered(employee.Id))
                {
                    cboEmployees.Items.Add(employee.FirstName + " " + employee.LastName);
                }
            }
            cboRoles.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
            {
                cboRoles.Items.Add(role.Name);
            }
        }
    }
}
