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
    public partial class AdminEmployeesControl : Form
    {
        SqlRepository sqlRepository;
        public AdminEmployeesControl()
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
        }

        public void LoadData()
        {
            var employees= sqlRepository.GetEmployees();
            lvAdminEmployeesControl.Items.Clear();
            foreach(var employee in employees)
            {
                lvAdminEmployeesControl.Items.Add(new ListViewItem(new string[] { employee.FirstName, employee.LastName, employee.Id.ToString(), Convert.ToString(employee.BirthDate.ToString("d")), employee.Email.ToString(), string.Format("{0:### ### ###}", long.Parse(employee.Phone)) }));
            }
        }

        private void AdminEmployeesControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdminEmployeeEdit_Click(object sender, EventArgs e)
        {
            if(lvAdminEmployeesControl.SelectedItems.Count> 0)
            {
                AdminEmployeeEdit adminEmployeeEdit = new AdminEmployeeEdit(Convert.ToInt32(lvAdminEmployeesControl.SelectedItems[0].SubItems[2].Text),this);
                adminEmployeeEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nevybral jste žádný záznam!");
            }
        }

        private void btnAdminUserAdd_Click(object sender, EventArgs e)
        {
            AdminEmployeeAdd adminEmployeeAdd = new AdminEmployeeAdd(this);
            adminEmployeeAdd.ShowDialog();
        }

        private void btnAdminUserDelete_Click(object sender, EventArgs e)
        {
            if (lvAdminEmployeesControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteEmployee(Convert.ToInt32(lvAdminEmployeesControl.SelectedItems[0].SubItems[2].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný zaměstnanec!");
            }
        }
    }
}
