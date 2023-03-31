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
        SqlRepository sqlRepository;
        public WorkHoursForm(bool admin)
        {
            InitializeComponent();
            Admin = admin;
            sqlRepository = new SqlRepository();
        }

        private void WorkHoursForm_Load(object sender, EventArgs e)
        {
            var hours = sqlRepository.GetHours();
            lvWorkHours.Items.Clear();
            if (Admin)
            {
                foreach(var hour in hours)
                {
                    lvWorkHours.Items.Add(new ListViewItem(new string[] {sqlRepository.GetEmployee(hour.IdEmployee).FirstName + " " + sqlRepository.GetEmployee(hour.IdEmployee).LastName, hour.IdContract.ToString(),hour.Id.ToString(), }));
                }
            }
        }
    }
}
