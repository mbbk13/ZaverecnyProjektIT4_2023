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
    public partial class AdminWorkTypeAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminWorkTypeControl AdminWorkTypeControl { get; set; }
        public AdminWorkTypeAdd(AdminWorkTypeControl adminWorkTypeControl)
        {
            InitializeComponent();
            AdminWorkTypeControl = adminWorkTypeControl;
            sqlRepository=new SqlRepository();
        }

        private void btnAdmiWorkTypeAddOK_Click(object sender, EventArgs e)
        {
            if (txtAdminWorkTypeAddDescription.Text != "" && txtAdminWorkTypeAddName.Text != "")
            {
                sqlRepository.AddWorkType(txtAdminWorkTypeAddName.Text,txtAdminWorkTypeAddDescription.Text);
                AdminWorkTypeControl.LoadData();
                Close();
            }
        }
    }
}
