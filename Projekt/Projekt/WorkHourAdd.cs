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
        private int IdUser { get; set; }
        public WorkHourAdd(bool admin,WorkHoursForm workHoursForm,int idUser)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            WorkHoursForm= workHoursForm;
            Admin= admin;
            IdUser = idUser;
        }

        private void WorkHourAdd_Load(object sender, EventArgs e)
        {
            dtpWorkHoursAddDate.MaxDate= DateTime.Now.Date;
            var employees = sqlRepository.GetEmployees();
            var contracts = sqlRepository.GetContracts();
            var workTypes = sqlRepository.GetWorkTypes();
            cboWorkHoursAddEmployees.Items.Clear();
            cbWorkHoursAddWorkType.Items.Clear ();
            cbWorkHoursAddContract.Items.Clear();
            if (Admin)
            {
                foreach(var employee in employees)
                {
                    cboWorkHoursAddEmployees.Items.Add(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
                }
                foreach (var workType in workTypes)
                {
                    cbWorkHoursAddWorkType.Items.Add(workType.Id + " - " + workType.Name);
                }
                foreach (var contract in contracts)
                {
                    cbWorkHoursAddContract.Items.Add(contract.Id + " - " + contract.CostumerName + ": " + contract.Description);
                }
            }
            else
            {
                dtpWorkHoursAddDate.Value= DateTime.Now.Date;
                dtpWorkHoursAddDate.Enabled = false;
                cboWorkHoursAddEmployees.Enabled = false;
                var user = sqlRepository.GetUser(IdUser);
                var employee = sqlRepository.GetEmployee(user.IdEmployee);
                cboWorkHoursAddEmployees.Items.Add(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
                cboWorkHoursAddEmployees.SelectedIndex = 0;
                foreach (var workType in workTypes)
                {
                    cbWorkHoursAddWorkType.Items.Add(workType.Id + " - " + workType.Name);
                }
                foreach (var contract in contracts)
                {
                    cbWorkHoursAddContract.Items.Add(contract.Id + " - " + contract.CostumerName + ": " + contract.Description);
                }
            }
        }

        private void btnWorkHourAddOK_Click(object sender, EventArgs e)
        {
            if (cbWorkHoursAddContract.Text!=""&&cbWorkHoursAddWorkType.Text!="")
            {
                var cbData = cboWorkHoursAddEmployees.Text;
                string[] employee = cbData.Split('-');
                string employeeId = employee[0].Trim();
                cbData = cbWorkHoursAddContract.Text;
                string[] contract = cbData.Split('-');
                string contractId = contract[0].Trim();
                cbData = cbWorkHoursAddWorkType.Text;
                string[] workType = cbData.Split('-');
                string workTypeId = workType[0].Trim();
                sqlRepository.AddWorkHour((int)nWorkHoursAddAmount.Value,dtpWorkHoursAddDate.Value,Convert.ToInt32(employeeId), Convert.ToInt32(contractId),Convert.ToInt32(workTypeId));
                WorkHoursForm.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("Nevyplnil jste všechna pole!");
            }
        }
    }
}
