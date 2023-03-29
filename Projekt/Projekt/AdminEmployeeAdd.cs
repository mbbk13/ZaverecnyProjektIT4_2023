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
    public partial class AdminEmployeeAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminEmployeesControl AdminEmployeesControl { get; set; }
        public AdminEmployeeAdd(AdminEmployeesControl adminEmployeesControl)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            AdminEmployeesControl= adminEmployeesControl;
        }

        private void btnAdminEmployeeEditOK_Click(object sender, EventArgs e)
        {
            if(txtAdminEmployeeAddEmail.Text!="" && txtAdminEmployeeAddLastname.Text!="" && txtAdminEmployeeAddName.Text!=""&& txtAdminEmployeeAddPhone.Text != "")
            {
                sqlRepository.AddEmployee(txtAdminEmployeeAddName.Text, txtAdminEmployeeAddLastname.Text, dtpAdminEmployeeAddBirthdate.Value, txtAdminEmployeeAddEmail.Text, txtAdminEmployeeAddPhone.Text);
                AdminEmployeesControl.LoadData();
                Close();
            }
        }
    }
}
