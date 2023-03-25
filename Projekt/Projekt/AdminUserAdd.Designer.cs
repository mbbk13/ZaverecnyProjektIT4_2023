namespace Projekt
{
    partial class AdminUserAdd
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
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.btnAdminEditOK = new System.Windows.Forms.Button();
            this.lblAdminAddEmployee = new System.Windows.Forms.Label();
            this.txtAdminAddUsername = new System.Windows.Forms.TextBox();
            this.lblAdminAddUsername = new System.Windows.Forms.Label();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.lblAdminAddRoles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboEmployees
            // 
            this.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(16, 106);
            this.cboEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(327, 24);
            this.cboEmployees.TabIndex = 12;
            // 
            // btnAdminEditOK
            // 
            this.btnAdminEditOK.Location = new System.Drawing.Point(210, 230);
            this.btnAdminEditOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminEditOK.Name = "btnAdminEditOK";
            this.btnAdminEditOK.Size = new System.Drawing.Size(133, 28);
            this.btnAdminEditOK.TabIndex = 11;
            this.btnAdminEditOK.Text = "OK";
            this.btnAdminEditOK.UseVisualStyleBackColor = true;
            this.btnAdminEditOK.Click += new System.EventHandler(this.btnAdminEditOK_Click);
            // 
            // lblAdminAddEmployee
            // 
            this.lblAdminAddEmployee.AutoSize = true;
            this.lblAdminAddEmployee.Location = new System.Drawing.Point(15, 85);
            this.lblAdminAddEmployee.Name = "lblAdminAddEmployee";
            this.lblAdminAddEmployee.Size = new System.Drawing.Size(89, 16);
            this.lblAdminAddEmployee.TabIndex = 9;
            this.lblAdminAddEmployee.Text = "Zaměstnanec";
            // 
            // txtAdminAddUsername
            // 
            this.txtAdminAddUsername.Location = new System.Drawing.Point(16, 41);
            this.txtAdminAddUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdminAddUsername.Name = "txtAdminAddUsername";
            this.txtAdminAddUsername.Size = new System.Drawing.Size(327, 22);
            this.txtAdminAddUsername.TabIndex = 8;
            // 
            // lblAdminAddUsername
            // 
            this.lblAdminAddUsername.AutoSize = true;
            this.lblAdminAddUsername.Location = new System.Drawing.Point(15, 11);
            this.lblAdminAddUsername.Name = "lblAdminAddUsername";
            this.lblAdminAddUsername.Size = new System.Drawing.Size(117, 16);
            this.lblAdminAddUsername.TabIndex = 7;
            this.lblAdminAddUsername.Text = "Uživatelské jméno";
            // 
            // cboRoles
            // 
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(16, 175);
            this.cboRoles.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(327, 24);
            this.cboRoles.TabIndex = 14;
            // 
            // lblAdminAddRoles
            // 
            this.lblAdminAddRoles.AutoSize = true;
            this.lblAdminAddRoles.Location = new System.Drawing.Point(15, 154);
            this.lblAdminAddRoles.Name = "lblAdminAddRoles";
            this.lblAdminAddRoles.Size = new System.Drawing.Size(36, 16);
            this.lblAdminAddRoles.TabIndex = 13;
            this.lblAdminAddRoles.Text = "Role";
            // 
            // AdminUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 271);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.lblAdminAddRoles);
            this.Controls.Add(this.cboEmployees);
            this.Controls.Add(this.btnAdminEditOK);
            this.Controls.Add(this.lblAdminAddEmployee);
            this.Controls.Add(this.txtAdminAddUsername);
            this.Controls.Add(this.lblAdminAddUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(346, 308);
            this.Name = "AdminUserAdd";
            this.Text = "Přidávání uživatele";
            this.Load += new System.EventHandler(this.AdminUserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Button btnAdminEditOK;
        private System.Windows.Forms.Label lblAdminAddEmployee;
        private System.Windows.Forms.TextBox txtAdminAddUsername;
        private System.Windows.Forms.Label lblAdminAddUsername;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Label lblAdminAddRoles;
    }
}