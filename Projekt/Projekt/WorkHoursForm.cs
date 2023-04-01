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
    public partial class WorkHoursForm : Form
    {
        public bool Admin { get; set; }
        public int IdUser { get; set; }
        private new Form Parent { get; set; }
        SqlRepository sqlRepository;
        public WorkHoursForm(bool admin,int idUser, Form parent)
        {
            InitializeComponent();
            Admin = admin;
            sqlRepository = new SqlRepository();
            IdUser= idUser;
            Parent = parent;
        }

        public void LoadData()
        {
            lvWorkHours.Items.Clear();
            if (Admin)
            {
                var hours = sqlRepository.GetHours();
                foreach (var hour in hours)
                {
                    lvWorkHours.Items.Add(new ListViewItem(new string[] { sqlRepository.GetEmployee(hour.IdEmployee).FirstName + " " + sqlRepository.GetEmployee(hour.IdEmployee).LastName, hour.IdContract.ToString(), hour.Id.ToString(), sqlRepository.GetWorkType(hour.IdWorkType).Name.ToString(), hour.Amount.ToString(), sqlRepository.GetContract(hour.IdContract).Description, Convert.ToString(hour.Date.ToString("d")) }));
                }
            }
            else
            {
                lvWorkHours.Columns[0].Width = 0;
                lvWorkHours.Columns[2].Width = 0;
                var hours = sqlRepository.GetHours(IdUser);
                foreach (var hour in hours)
                {
                    lvWorkHours.Items.Add(new ListViewItem(new string[] { "", hour.IdContract.ToString(), hour.Id.ToString(), sqlRepository.GetWorkType(hour.IdWorkType).Name.ToString(), hour.Amount.ToString(), sqlRepository.GetContract(hour.IdContract).Description, Convert.ToString(hour.Date.ToString("d")) }));
                }
            }
        }

        private void WorkHoursForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdminUserEdit_Click(object sender, EventArgs e)
        {
            if (lvWorkHours.SelectedItems.Count>0)
            {
                if (Admin)
                {
                    WorkHourEdit workHourEdit = new WorkHourEdit(true, Convert.ToInt32(lvWorkHours.SelectedItems[0].SubItems[2].Text),this);
                    workHourEdit.ShowDialog();
                }
                else
                {
                    if (Convert.ToDateTime(lvWorkHours.SelectedItems[0].SubItems[6].Text).Date == DateTime.Now.Date)
                    {
                        WorkHourEdit workHourEdit = new WorkHourEdit(false, Convert.ToInt32(lvWorkHours.SelectedItems[0].SubItems[2].Text), this);
                        workHourEdit.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nelze upravovat záznamy z jiného dne! V případě potřeby kontaktujte administrátora.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nevybral jste žádný záznam!");
            }
        }

        private void WorkHoursForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Close();
        }

        private void btnAdminUserAdd_Click(object sender, EventArgs e)
        {
            WorkHourAdd workHourAdd = new WorkHourAdd(Admin,this);
            workHourAdd.ShowDialog();
        }
    }
}
