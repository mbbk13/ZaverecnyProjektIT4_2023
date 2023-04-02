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
    public partial class AdminWorkTypeEdit : Form
    {
        public int IdWorkType { get; set; }
        SqlRepository sqlRepository;
        public AdminWorkTypeControl AdminWorkTypeControl { get; set; }
        public AdminWorkTypeEdit(int idWorkType, AdminWorkTypeControl adminWorkTypeControl)
        {
            InitializeComponent();
            IdWorkType = idWorkType;
            sqlRepository= new SqlRepository();
            AdminWorkTypeControl= adminWorkTypeControl;
        }

        private void AdminWorkTypeEdit_Load(object sender, EventArgs e)
        {
            var workType = sqlRepository.GetWorkType(IdWorkType);
            if (workType != null)
            {
                txtAdminWorkTypeEditDescription.Text = workType.Description;
                txtAdminWorkTypeEditName.Text = workType.Name;
            }
            else
            {
                MessageBox.Show("Typ práce takového identifikačního čísla se nenašel!");
            }
        }

        private void btnAdminWorkTypeEditOK_Click(object sender, EventArgs e)
        {
            if (txtAdminWorkTypeEditName.Text != "" && txtAdminWorkTypeEditDescription.Text != "")
            {
                sqlRepository.UpdateWorkType(txtAdminWorkTypeEditName.Text,txtAdminWorkTypeEditDescription.Text,IdWorkType);
                AdminWorkTypeControl.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("Nevyplnil jste všechna pole!");
            }
        }
    }
}
