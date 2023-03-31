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
    public partial class AdminWorkTypeControl : Form
    {
        SqlRepository sqlRepository;
        public AdminWorkTypeControl()
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
        }

        private void AdminWorkTypeControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var workTypes = sqlRepository.GetWorkTypes();
            lvAdminWorkTypeControl.Items.Clear();
            foreach (var workType in workTypes)
            {
                lvAdminWorkTypeControl.Items.Add(new ListViewItem(new string[] { workType.Name, workType.Id.ToString(), workType.Description }));
            }
        }

        private void btnAdminRoleEdit_Click(object sender, EventArgs e)
        {
            if(lvAdminWorkTypeControl.SelectedItems.Count > 0)
            {
                AdminWorkTypeEdit adminWorkTypeControlEdit = new AdminWorkTypeEdit(Convert.ToInt32(lvAdminWorkTypeControl.SelectedItems[0].SubItems[1].Text),this);
                adminWorkTypeControlEdit.ShowDialog();
            }
        }

        private void btnAdminRoleAdd_Click(object sender, EventArgs e)
        {
            AdminWorkTypeAdd adminWrokTypeAdd = new AdminWorkTypeAdd(this);
            adminWrokTypeAdd.ShowDialog();
        }

        private void btnAdminRoleDelete_Click(object sender, EventArgs e)
        {
            if (lvAdminWorkTypeControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteWorkType(Convert.ToInt32(lvAdminWorkTypeControl.SelectedItems[0].SubItems[1].Text));
                LoadData();
            }
        }
    }
}
