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
    public partial class WorkHourAdd : Form
    {
        SqlRepository sqlRepository;
        private bool Admin { get; set; }
        private WorkHoursForm WorkHoursForm { get; set; }
        public WorkHourAdd(bool admin,WorkHoursForm workHoursForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            WorkHoursForm= workHoursForm;
        }

        private void WorkHourAdd_Load(object sender, EventArgs e)
        {
            dtpWorkHoursAddDate.MaxDate = DateTime.Now;
            if (Admin)
            {
                
            }
            else
            {

            }
        }
    }
}
