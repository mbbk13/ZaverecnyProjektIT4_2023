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
    public partial class AdminContractAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminContractControl AdminContractControl { get; set; }
        public AdminContractAdd(AdminContractControl adminContractControl)
        {
            InitializeComponent();
            sqlRepository= new SqlRepository();
            AdminContractControl= adminContractControl;
        }

        private void btnAdminContractAddOK_Click(object sender, EventArgs e)
        {
            if (txtAdminContractAddDescription.Text != "" && txtAdminContractorAddName.Text != "")
            {
                sqlRepository.AddContract(txtAdminContractorAddName.Text, txtAdminContractAddDescription.Text);
                AdminContractControl.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("Nevyplnil jste všechna pole!");
            }
        }
    }
}
