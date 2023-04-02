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
    public partial class WorkHourEdit : Form
    {
        public int IdHour { get; set; }
        public bool Admin { get; set; }
        SqlRepository sqlRepository;
        private new WorkHoursForm Parent { get; set; }
        public WorkHourEdit(bool admin,int idHour,WorkHoursForm parent)
        {
            InitializeComponent();
            IdHour = idHour;
            Admin = admin;
            sqlRepository = new SqlRepository();
            Parent=parent;
        }

        private void WorkHourEdit_Load(object sender, EventArgs e)
        {
            dtpWorkHoursEditDate.MaxDate=DateTime.Now;
            var hour = sqlRepository.GetHour(IdHour);
            var contracts = sqlRepository.GetContracts();
            var workTypes = sqlRepository.GetWorkTypes();
            cboWorkHoursEditEmployees.Items.Clear();
            cbWorkHoursEditContract.Items.Clear();
            cbWorkHoursEditWorkType.Items.Clear();
            if (Admin)
            {
                var employees = sqlRepository.GetEmployees();
                nWorkHoursEditAmount.Value = hour.Amount;
                dtpWorkHoursEditDate.Value = hour.Date;
                foreach (var employee in employees)
                {
                    cboWorkHoursEditEmployees.Items.Add(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
                }
                foreach (var workType in workTypes)
                {
                    cbWorkHoursEditWorkType.Items.Add(workType.Id + " - " + workType.Name);
                }
                foreach (var contract in contracts)
                {
                    cbWorkHoursEditContract.Items.Add(contract.Id + " - " + contract.CostumerName + ": " + contract.Description);
                }
            }
            else
            {
                var employee = sqlRepository.GetEmployee(hour.IdEmployee);
                nWorkHoursEditAmount.Value = hour.Amount;
                dtpWorkHoursEditDate.Value = hour.Date;
                dtpWorkHoursEditDate.Enabled = false;
                cboWorkHoursEditEmployees.Enabled = false;
                cboWorkHoursEditEmployees.Items.Add(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
                cboWorkHoursEditEmployees.SelectedIndex=0;
                foreach (var workType in workTypes)
                {
                    cbWorkHoursEditWorkType.Items.Add(workType.Id + " - " + workType.Name);
                }
                foreach (var contract in contracts)
                {
                    cbWorkHoursEditContract.Items.Add(contract.Id + " - " + contract.CostumerName + ": " + contract.Description);
                }
            }
        }

        private void btnAdminEmployeeEditOK_Click(object sender, EventArgs e)
        {
            if (cboWorkHoursEditEmployees.Text != "" && cbWorkHoursEditContract.Text != "" && cbWorkHoursEditWorkType.Text != "")
            {
                var cbData = cboWorkHoursEditEmployees.Text;
                string[] employee = cbData.Split('-');
                string employeeId = employee[0].Trim();
                cbData = cbWorkHoursEditWorkType.Text;
                string[] workType = cbData.Split('-');
                string workTypeId = workType[0].Trim();
                cbData = cbWorkHoursEditContract.Text;
                string[] contract = cbData.Split('-');
                string contractId = contract[0].Trim();
                sqlRepository.UpdateWorkHour(IdHour, (int)nWorkHoursEditAmount.Value, dtpWorkHoursEditDate.Value, Convert.ToInt32(employeeId), Convert.ToInt32(contractId), Convert.ToInt32(workTypeId));
                Parent.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("Nevyplnil jste všechna pole!");
            }
        }
    }
}
