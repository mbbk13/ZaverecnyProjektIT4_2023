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
    public partial class AdminContractEdit : Form
    {
        SqlRepository sqlRepository;
        public int IdContract { get; set; }
        public AdminContractEdit(int idContract)
        {
            InitializeComponent();
            IdContract = idContract;
            sqlRepository = new SqlRepository();
        }

        private void AdminContractEdit_Load(object sender, EventArgs e)
        {
            var contract = sqlRepository.GetContract(IdContract);
            if (contract != null)
            {
                txtAdminContractEditDescription.Text = contract.Description;
                txtAdminContractEditName.Text = contract.CostumerName;
            }
        }


    }
}
