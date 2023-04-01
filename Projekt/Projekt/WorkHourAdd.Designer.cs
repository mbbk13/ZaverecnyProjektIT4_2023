namespace Projekt
{
    partial class WorkHourAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nWorkHoursAddAmount = new System.Windows.Forms.NumericUpDown();
            this.cbWorkHoursEditWorkType = new System.Windows.Forms.ComboBox();
            this.lblWorkHoursEditWorkType = new System.Windows.Forms.Label();
            this.cbWorkHoursEditContract = new System.Windows.Forms.ComboBox();
            this.cboWorkHoursEditEmployees = new System.Windows.Forms.ComboBox();
            this.btnAdminEmployeeEditOK = new System.Windows.Forms.Button();
            this.lblWorkHoursEditContract = new System.Windows.Forms.Label();
            this.lblWorkHoursEditEmployee = new System.Windows.Forms.Label();
            this.lblWorkHoursAddAmount = new System.Windows.Forms.Label();
            this.dtpWorkHoursAddDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkHoursAddDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkHoursAddAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // nWorkHoursAddAmount
            // 
            this.nWorkHoursAddAmount.Location = new System.Drawing.Point(12, 35);
            this.nWorkHoursAddAmount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nWorkHoursAddAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWorkHoursAddAmount.Name = "nWorkHoursAddAmount";
            this.nWorkHoursAddAmount.Size = new System.Drawing.Size(344, 22);
            this.nWorkHoursAddAmount.TabIndex = 40;
            this.nWorkHoursAddAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbWorkHoursEditWorkType
            // 
            this.cbWorkHoursEditWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkHoursEditWorkType.FormattingEnabled = true;
            this.cbWorkHoursEditWorkType.Location = new System.Drawing.Point(10, 271);
            this.cbWorkHoursEditWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkHoursEditWorkType.Name = "cbWorkHoursEditWorkType";
            this.cbWorkHoursEditWorkType.Size = new System.Drawing.Size(351, 24);
            this.cbWorkHoursEditWorkType.TabIndex = 39;
            // 
            // lblWorkHoursEditWorkType
            // 
            this.lblWorkHoursEditWorkType.AutoSize = true;
            this.lblWorkHoursEditWorkType.Location = new System.Drawing.Point(10, 245);
            this.lblWorkHoursEditWorkType.Name = "lblWorkHoursEditWorkType";
            this.lblWorkHoursEditWorkType.Size = new System.Drawing.Size(134, 16);
            this.lblWorkHoursEditWorkType.TabIndex = 38;
            this.lblWorkHoursEditWorkType.Text = "Typ odvedené práce";
            // 
            // cbWorkHoursEditContract
            // 
            this.cbWorkHoursEditContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkHoursEditContract.FormattingEnabled = true;
            this.cbWorkHoursEditContract.Location = new System.Drawing.Point(10, 211);
            this.cbWorkHoursEditContract.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkHoursEditContract.Name = "cbWorkHoursEditContract";
            this.cbWorkHoursEditContract.Size = new System.Drawing.Size(351, 24);
            this.cbWorkHoursEditContract.TabIndex = 37;
            // 
            // cboWorkHoursEditEmployees
            // 
            this.cboWorkHoursEditEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorkHoursEditEmployees.FormattingEnabled = true;
            this.cboWorkHoursEditEmployees.Location = new System.Drawing.Point(11, 151);
            this.cboWorkHoursEditEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cboWorkHoursEditEmployees.Name = "cboWorkHoursEditEmployees";
            this.cboWorkHoursEditEmployees.Size = new System.Drawing.Size(351, 24);
            this.cboWorkHoursEditEmployees.TabIndex = 36;
            // 
            // btnAdminEmployeeEditOK
            // 
            this.btnAdminEmployeeEditOK.Location = new System.Drawing.Point(289, 318);
            this.btnAdminEmployeeEditOK.Name = "btnAdminEmployeeEditOK";
            this.btnAdminEmployeeEditOK.Size = new System.Drawing.Size(75, 23);
            this.btnAdminEmployeeEditOK.TabIndex = 35;
            this.btnAdminEmployeeEditOK.Text = "OK";
            this.btnAdminEmployeeEditOK.UseVisualStyleBackColor = true;
            // 
            // lblWorkHoursEditContract
            // 
            this.lblWorkHoursEditContract.AutoSize = true;
            this.lblWorkHoursEditContract.Location = new System.Drawing.Point(10, 185);
            this.lblWorkHoursEditContract.Name = "lblWorkHoursEditContract";
            this.lblWorkHoursEditContract.Size = new System.Drawing.Size(59, 16);
            this.lblWorkHoursEditContract.TabIndex = 34;
            this.lblWorkHoursEditContract.Text = "Zakázka";
            // 
            // lblWorkHoursEditEmployee
            // 
            this.lblWorkHoursEditEmployee.AutoSize = true;
            this.lblWorkHoursEditEmployee.Location = new System.Drawing.Point(10, 125);
            this.lblWorkHoursEditEmployee.Name = "lblWorkHoursEditEmployee";
            this.lblWorkHoursEditEmployee.Size = new System.Drawing.Size(89, 16);
            this.lblWorkHoursEditEmployee.TabIndex = 33;
            this.lblWorkHoursEditEmployee.Text = "Zaměstnanec";
            // 
            // lblWorkHoursAddAmount
            // 
            this.lblWorkHoursAddAmount.AutoSize = true;
            this.lblWorkHoursAddAmount.Location = new System.Drawing.Point(12, 9);
            this.lblWorkHoursAddAmount.Name = "lblWorkHoursAddAmount";
            this.lblWorkHoursAddAmount.Size = new System.Drawing.Size(192, 16);
            this.lblWorkHoursAddAmount.TabIndex = 30;
            this.lblWorkHoursAddAmount.Text = "Množství odpracovaných hodin";
            // 
            // dtpWorkHoursAddDate
            // 
            this.dtpWorkHoursAddDate.Location = new System.Drawing.Point(10, 93);
            this.dtpWorkHoursAddDate.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dtpWorkHoursAddDate.Name = "dtpWorkHoursAddDate";
            this.dtpWorkHoursAddDate.Size = new System.Drawing.Size(352, 22);
            this.dtpWorkHoursAddDate.TabIndex = 32;
            // 
            // lblWorkHoursAddDate
            // 
            this.lblWorkHoursAddDate.AutoSize = true;
            this.lblWorkHoursAddDate.Location = new System.Drawing.Point(10, 67);
            this.lblWorkHoursAddDate.Name = "lblWorkHoursAddDate";
            this.lblWorkHoursAddDate.Size = new System.Drawing.Size(46, 16);
            this.lblWorkHoursAddDate.TabIndex = 31;
            this.lblWorkHoursAddDate.Text = "Datum";
            // 
            // WorkHourAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 353);
            this.Controls.Add(this.nWorkHoursAddAmount);
            this.Controls.Add(this.cbWorkHoursEditWorkType);
            this.Controls.Add(this.lblWorkHoursEditWorkType);
            this.Controls.Add(this.cbWorkHoursEditContract);
            this.Controls.Add(this.cboWorkHoursEditEmployees);
            this.Controls.Add(this.btnAdminEmployeeEditOK);
            this.Controls.Add(this.lblWorkHoursEditContract);
            this.Controls.Add(this.lblWorkHoursEditEmployee);
            this.Controls.Add(this.dtpWorkHoursAddDate);
            this.Controls.Add(this.lblWorkHoursAddDate);
            this.Controls.Add(this.lblWorkHoursAddAmount);
            this.Name = "WorkHourAdd";
            this.Text = "Přidávání odpracovaných hodin";
            this.Load += new System.EventHandler(this.WorkHourAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nWorkHoursAddAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nWorkHoursAddAmount;
        private System.Windows.Forms.ComboBox cbWorkHoursEditWorkType;
        private System.Windows.Forms.Label lblWorkHoursEditWorkType;
        private System.Windows.Forms.ComboBox cbWorkHoursEditContract;
        private System.Windows.Forms.ComboBox cboWorkHoursEditEmployees;
        private System.Windows.Forms.Button btnAdminEmployeeEditOK;
        private System.Windows.Forms.Label lblWorkHoursEditContract;
        private System.Windows.Forms.Label lblWorkHoursEditEmployee;
        private System.Windows.Forms.Label lblWorkHoursAddAmount;
        private System.Windows.Forms.DateTimePicker dtpWorkHoursAddDate;
        private System.Windows.Forms.Label lblWorkHoursAddDate;
    }
}