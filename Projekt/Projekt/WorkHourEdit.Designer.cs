namespace Projekt
{
    partial class WorkHourEdit
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
            this.btnAdminEmployeeEditOK = new System.Windows.Forms.Button();
            this.lblWorkHoursEditContract = new System.Windows.Forms.Label();
            this.lblWorkHoursEditEmployee = new System.Windows.Forms.Label();
            this.dtpWorkHoursEditDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkHoursEditDate = new System.Windows.Forms.Label();
            this.lblWorkHoursEditAmount = new System.Windows.Forms.Label();
            this.cboWorkHoursEditEmployees = new System.Windows.Forms.ComboBox();
            this.cbWorkHoursEditContract = new System.Windows.Forms.ComboBox();
            this.cbWorkHoursEditWorkType = new System.Windows.Forms.ComboBox();
            this.lblWorkHoursEditWorkType = new System.Windows.Forms.Label();
            this.nWorkHoursEditAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkHoursEditAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminEmployeeEditOK
            // 
            this.btnAdminEmployeeEditOK.Location = new System.Drawing.Point(289, 318);
            this.btnAdminEmployeeEditOK.Name = "btnAdminEmployeeEditOK";
            this.btnAdminEmployeeEditOK.Size = new System.Drawing.Size(75, 23);
            this.btnAdminEmployeeEditOK.TabIndex = 24;
            this.btnAdminEmployeeEditOK.Text = "OK";
            this.btnAdminEmployeeEditOK.UseVisualStyleBackColor = true;
            this.btnAdminEmployeeEditOK.Click += new System.EventHandler(this.btnAdminEmployeeEditOK_Click);
            // 
            // lblWorkHoursEditContract
            // 
            this.lblWorkHoursEditContract.AutoSize = true;
            this.lblWorkHoursEditContract.Location = new System.Drawing.Point(10, 185);
            this.lblWorkHoursEditContract.Name = "lblWorkHoursEditContract";
            this.lblWorkHoursEditContract.Size = new System.Drawing.Size(59, 16);
            this.lblWorkHoursEditContract.TabIndex = 22;
            this.lblWorkHoursEditContract.Text = "Zakázka";
            // 
            // lblWorkHoursEditEmployee
            // 
            this.lblWorkHoursEditEmployee.AutoSize = true;
            this.lblWorkHoursEditEmployee.Location = new System.Drawing.Point(10, 125);
            this.lblWorkHoursEditEmployee.Name = "lblWorkHoursEditEmployee";
            this.lblWorkHoursEditEmployee.Size = new System.Drawing.Size(89, 16);
            this.lblWorkHoursEditEmployee.TabIndex = 20;
            this.lblWorkHoursEditEmployee.Text = "Zaměstnanec";
            // 
            // dtpWorkHoursEditDate
            // 
            this.dtpWorkHoursEditDate.Location = new System.Drawing.Point(10, 93);
            this.dtpWorkHoursEditDate.Name = "dtpWorkHoursEditDate";
            this.dtpWorkHoursEditDate.Size = new System.Drawing.Size(352, 22);
            this.dtpWorkHoursEditDate.TabIndex = 19;
            // 
            // lblWorkHoursEditDate
            // 
            this.lblWorkHoursEditDate.AutoSize = true;
            this.lblWorkHoursEditDate.Location = new System.Drawing.Point(10, 67);
            this.lblWorkHoursEditDate.Name = "lblWorkHoursEditDate";
            this.lblWorkHoursEditDate.Size = new System.Drawing.Size(46, 16);
            this.lblWorkHoursEditDate.TabIndex = 18;
            this.lblWorkHoursEditDate.Text = "Datum";
            // 
            // lblWorkHoursEditAmount
            // 
            this.lblWorkHoursEditAmount.AutoSize = true;
            this.lblWorkHoursEditAmount.Location = new System.Drawing.Point(12, 9);
            this.lblWorkHoursEditAmount.Name = "lblWorkHoursEditAmount";
            this.lblWorkHoursEditAmount.Size = new System.Drawing.Size(192, 16);
            this.lblWorkHoursEditAmount.TabIndex = 14;
            this.lblWorkHoursEditAmount.Text = "Množství odpracovaných hodin";
            // 
            // cboWorkHoursEditEmployees
            // 
            this.cboWorkHoursEditEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorkHoursEditEmployees.FormattingEnabled = true;
            this.cboWorkHoursEditEmployees.Location = new System.Drawing.Point(11, 151);
            this.cboWorkHoursEditEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cboWorkHoursEditEmployees.Name = "cboWorkHoursEditEmployees";
            this.cboWorkHoursEditEmployees.Size = new System.Drawing.Size(351, 24);
            this.cboWorkHoursEditEmployees.TabIndex = 25;
            // 
            // cbWorkHoursEditContract
            // 
            this.cbWorkHoursEditContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkHoursEditContract.FormattingEnabled = true;
            this.cbWorkHoursEditContract.Location = new System.Drawing.Point(10, 211);
            this.cbWorkHoursEditContract.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkHoursEditContract.Name = "cbWorkHoursEditContract";
            this.cbWorkHoursEditContract.Size = new System.Drawing.Size(351, 24);
            this.cbWorkHoursEditContract.TabIndex = 26;
            // 
            // cbWorkHoursEditWorkType
            // 
            this.cbWorkHoursEditWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkHoursEditWorkType.FormattingEnabled = true;
            this.cbWorkHoursEditWorkType.Location = new System.Drawing.Point(10, 271);
            this.cbWorkHoursEditWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkHoursEditWorkType.Name = "cbWorkHoursEditWorkType";
            this.cbWorkHoursEditWorkType.Size = new System.Drawing.Size(351, 24);
            this.cbWorkHoursEditWorkType.TabIndex = 28;
            // 
            // lblWorkHoursEditWorkType
            // 
            this.lblWorkHoursEditWorkType.AutoSize = true;
            this.lblWorkHoursEditWorkType.Location = new System.Drawing.Point(10, 245);
            this.lblWorkHoursEditWorkType.Name = "lblWorkHoursEditWorkType";
            this.lblWorkHoursEditWorkType.Size = new System.Drawing.Size(134, 16);
            this.lblWorkHoursEditWorkType.TabIndex = 27;
            this.lblWorkHoursEditWorkType.Text = "Typ odvedené práce";
            // 
            // nWorkHoursEditAmount
            // 
            this.nWorkHoursEditAmount.Location = new System.Drawing.Point(12, 35);
            this.nWorkHoursEditAmount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nWorkHoursEditAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWorkHoursEditAmount.Name = "nWorkHoursEditAmount";
            this.nWorkHoursEditAmount.Size = new System.Drawing.Size(344, 22);
            this.nWorkHoursEditAmount.TabIndex = 29;
            this.nWorkHoursEditAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WorkHourEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 353);
            this.Controls.Add(this.nWorkHoursEditAmount);
            this.Controls.Add(this.cbWorkHoursEditWorkType);
            this.Controls.Add(this.lblWorkHoursEditWorkType);
            this.Controls.Add(this.cbWorkHoursEditContract);
            this.Controls.Add(this.cboWorkHoursEditEmployees);
            this.Controls.Add(this.btnAdminEmployeeEditOK);
            this.Controls.Add(this.lblWorkHoursEditContract);
            this.Controls.Add(this.lblWorkHoursEditEmployee);
            this.Controls.Add(this.dtpWorkHoursEditDate);
            this.Controls.Add(this.lblWorkHoursEditDate);
            this.Controls.Add(this.lblWorkHoursEditAmount);
            this.Name = "WorkHourEdit";
            this.Text = "Editace odpracovaných hodin";
            this.Load += new System.EventHandler(this.WorkHourEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nWorkHoursEditAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminEmployeeEditOK;
        private System.Windows.Forms.Label lblWorkHoursEditContract;
        private System.Windows.Forms.Label lblWorkHoursEditEmployee;
        private System.Windows.Forms.DateTimePicker dtpWorkHoursEditDate;
        private System.Windows.Forms.Label lblWorkHoursEditDate;
        private System.Windows.Forms.Label lblWorkHoursEditAmount;
        private System.Windows.Forms.ComboBox cboWorkHoursEditEmployees;
        private System.Windows.Forms.ComboBox cbWorkHoursEditContract;
        private System.Windows.Forms.ComboBox cbWorkHoursEditWorkType;
        private System.Windows.Forms.Label lblWorkHoursEditWorkType;
        private System.Windows.Forms.NumericUpDown nWorkHoursEditAmount;
    }
}