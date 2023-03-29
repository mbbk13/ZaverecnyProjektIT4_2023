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
    public partial class AdminContractControl : Form
    {
        SqlRepository sqlRepository;
        public AdminContractControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminContractControl_Load(object sender, EventArgs e)
        {
            lvAdminContractControl.Items.Clear();
            var contracts = sqlRepository.GetContracts();
            foreach(var contract in contracts)
            {
                lvAdminContractControl.Items.Add(new ListViewItem(new string[] { contract.CostumerName, contract.Description, contract.Id.ToString() }));
            }
        }

        private void btnAdminContractEdit_Click(object sender, EventArgs e)
        {
            if(lvAdminContractControl.SelectedItems.Count > 0)
            {
                AdminContractEdit adminContractEdit = new AdminContractEdit(Convert.ToInt32(lvAdminContractControl.SelectedItems[0].SubItems[2].Text));
                adminContractEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nevybral jste žádný záznám!");
            }
        }
    }
}
