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
    public partial class AdminEmployeeEdit : Form
    {
        SqlRepository sqlRepository;
        private int IdEmployee { get; set; }
        public AdminEmployeeEdit(int idEmployee)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            IdEmployee = idEmployee;
        }

        private void AdminEmployeeEdit_Load(object sender, EventArgs e)
        {
            var employee = sqlRepository.GetEmployee(IdEmployee);
            if (employee != null)
            {
                txtAdminEmployeeEditName.Text = employee.FirstName;
                txtAdminEmployeeEditEmail.Text = employee.Email;
                txtAdminEmployeeEditLastname.Text = employee.LastName;
                txtAdminEmployeeEditPhone.Text = employee.Phone;
                //MessageBox.Show(employee.BirthDate.ToString());
                dtpAdminEmployeeEditBirthdate.Value = employee.BirthDate;
            }
        }

        private void btnAdminEmployeeEditOK_Click(object sender, EventArgs e)
        {

        }
    }
}
