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
        public AdminUsersControl ParentForm { get; set; }
        public AdminUserAdd(AdminUsersControl parent)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            ParentForm= parent;
        }

        private void AdminUserAdd_Load(object sender, EventArgs e)
        {
            cboEmployees.Items.Clear();
            var employees = sqlRepository.GetEmployees();
            foreach ( var employee in employees )
            {
                if(!sqlRepository.IsUsered(employee.Id))
                {
                    cboEmployees.Items.Add(employee.FirstName + " " + employee.LastName + " - "+employee.Id);
                }
            }
            cboRoles.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
            {
                cboRoles.Items.Add(role.Name);
            }
        }

        private void btnAdminEditOK_Click(object sender, EventArgs e)
        {
            if (txtAdminAddUsername.Text != null && cboEmployees.Text != null && cboRoles.Text != null)
            {
                var idEmployee = cboEmployees.Text.Split('-');
                var user = new User(txtAdminAddUsername.Text);
                var role = sqlRepository.GetRole(cboRoles.Text);
                user.ResetPassword();
                sqlRepository.AddUser(user.UserName, Convert.ToInt32(idEmployee[1].Trim()), role.Id,user.Password,user.PasswordSalt);
                ParentForm.LoadData();
                Close();
                MessageBox.Show("Uživatel úspěšně přidán!");
            }
            else{
                MessageBox.Show("Musítě vyplnit všechna pole!");
            }
            //var id = cboEmployees.Text.Split('-');
            //MessageBox.Show("+"+ id[1].Trim());
        }
    }
}
