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
            this.cbWorkHoursAddWorkType = new System.Windows.Forms.ComboBox();
            this.lblWorkHoursAddWorkType = new System.Windows.Forms.Label();
            this.cbWorkHoursAddContract = new System.Windows.Forms.ComboBox();
            this.cboWorkHoursAddEmployees = new System.Windows.Forms.ComboBox();
            this.btnWorkHourAddOK = new System.Windows.Forms.Button();
            this.lblWorkHoursAddContract = new System.Windows.Forms.Label();
            this.lblWorkHoursAddEmployee = new System.Windows.Forms.Label();
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
            this.nWorkHoursAddAmount.Size = new System.Drawing.Size(349, 22);
            this.nWorkHoursAddAmount.TabIndex = 40;
            this.nWorkHoursAddAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbWorkHoursAddWorkType
            // 
            this.cbWorkHoursAddWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkHoursAddWorkType.FormattingEnabled = true;
            this.cbWorkHoursAddWorkType.Location = new System.Drawing.Point(10, 271);
            this.cbWorkHoursAddWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkHoursAddWorkType.Name = "cbWorkHoursAddWorkType";
            this.cbWorkHoursAddWorkType.Size = new System.Drawing.Size(351, 24);
            this.cbWorkHoursAddWorkType.TabIndex = 39;
            // 
            // lblWorkHoursAddWorkType
            // 
            this.lblWorkHoursAddWorkType.AutoSize = true;
            this.lblWorkHoursAddWorkType.Location = new System.Drawing.Point(10, 245);
            this.lblWorkHoursAddWorkType.Name = "lblWorkHoursAddWorkType";
            this.lblWorkHoursAddWorkType.Size = new System.Drawing.Size(134, 16);
            this.lblWorkHoursAddWorkType.TabIndex = 38;
            this.lblWorkHoursAddWorkType.Text = "Typ odvedené práce";
            // 
            // cbWorkHoursAddContract
            // 
            this.cbWorkHoursAddContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkHoursAddContract.FormattingEnabled = true;
            this.cbWorkHoursAddContract.Location = new System.Drawing.Point(10, 211);
            this.cbWorkHoursAddContract.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkHoursAddContract.Name = "cbWorkHoursAddContract";
            this.cbWorkHoursAddContract.Size = new System.Drawing.Size(351, 24);
            this.cbWorkHoursAddContract.TabIndex = 37;
            // 
            // cboWorkHoursAddEmployees
            // 
            this.cboWorkHoursAddEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorkHoursAddEmployees.FormattingEnabled = true;
            this.cboWorkHoursAddEmployees.Location = new System.Drawing.Point(11, 151);
            this.cboWorkHoursAddEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cboWorkHoursAddEmployees.Name = "cboWorkHoursAddEmployees";
            this.cboWorkHoursAddEmployees.Size = new System.Drawing.Size(351, 24);
            this.cboWorkHoursAddEmployees.TabIndex = 36;
            // 
            // btnWorkHourAddOK
            // 
            this.btnWorkHourAddOK.Location = new System.Drawing.Point(289, 318);
            this.btnWorkHourAddOK.Name = "btnWorkHourAddOK";
            this.btnWorkHourAddOK.Size = new System.Drawing.Size(75, 23);
            this.btnWorkHourAddOK.TabIndex = 35;
            this.btnWorkHourAddOK.Text = "OK";
            this.btnWorkHourAddOK.UseVisualStyleBackColor = true;
            this.btnWorkHourAddOK.Click += new System.EventHandler(this.btnWorkHourAddOK_Click);
            // 
            // lblWorkHoursAddContract
            // 
            this.lblWorkHoursAddContract.AutoSize = true;
            this.lblWorkHoursAddContract.Location = new System.Drawing.Point(10, 185);
            this.lblWorkHoursAddContract.Name = "lblWorkHoursAddContract";
            this.lblWorkHoursAddContract.Size = new System.Drawing.Size(59, 16);
            this.lblWorkHoursAddContract.TabIndex = 34;
            this.lblWorkHoursAddContract.Text = "Zakázka";
            // 
            // lblWorkHoursAddEmployee
            // 
            this.lblWorkHoursAddEmployee.AutoSize = true;
            this.lblWorkHoursAddEmployee.Location = new System.Drawing.Point(10, 125);
            this.lblWorkHoursAddEmployee.Name = "lblWorkHoursAddEmployee";
            this.lblWorkHoursAddEmployee.Size = new System.Drawing.Size(89, 16);
            this.lblWorkHoursAddEmployee.TabIndex = 33;
            this.lblWorkHoursAddEmployee.Text = "Zaměstnanec";
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
            this.Controls.Add(this.cbWorkHoursAddWorkType);
            this.Controls.Add(this.lblWorkHoursAddWorkType);
            this.Controls.Add(this.cbWorkHoursAddContract);
            this.Controls.Add(this.cboWorkHoursAddEmployees);
            this.Controls.Add(this.btnWorkHourAddOK);
            this.Controls.Add(this.lblWorkHoursAddContract);
            this.Controls.Add(this.lblWorkHoursAddEmployee);
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
        private System.Windows.Forms.ComboBox cbWorkHoursAddWorkType;
        private System.Windows.Forms.Label lblWorkHoursAddWorkType;
        private System.Windows.Forms.ComboBox cbWorkHoursAddContract;
        private System.Windows.Forms.ComboBox cboWorkHoursAddEmployees;
        private System.Windows.Forms.Button btnWorkHourAddOK;
        private System.Windows.Forms.Label lblWorkHoursAddContract;
        private System.Windows.Forms.Label lblWorkHoursAddEmployee;
        private System.Windows.Forms.Label lblWorkHoursAddAmount;
        private System.Windows.Forms.DateTimePicker dtpWorkHoursAddDate;
        private System.Windows.Forms.Label lblWorkHoursAddDate;
    }
}