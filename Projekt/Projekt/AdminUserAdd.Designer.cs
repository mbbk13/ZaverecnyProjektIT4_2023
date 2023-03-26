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
            this.lblAdminUserAddEmployee = new System.Windows.Forms.Label();
            this.txtAdminUserAddUsername = new System.Windows.Forms.TextBox();
            this.lblAdminUserAddUsername = new System.Windows.Forms.Label();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.lblAdminUserAddRoles = new System.Windows.Forms.Label();
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
            // lblAdminUserAddEmployee
            // 
            this.lblAdminUserAddEmployee.AutoSize = true;
            this.lblAdminUserAddEmployee.Location = new System.Drawing.Point(15, 85);
            this.lblAdminUserAddEmployee.Name = "lblAdminUserAddEmployee";
            this.lblAdminUserAddEmployee.Size = new System.Drawing.Size(89, 16);
            this.lblAdminUserAddEmployee.TabIndex = 9;
            this.lblAdminUserAddEmployee.Text = "Zaměstnanec";
            // 
            // txtAdminUserAddUsername
            // 
            this.txtAdminUserAddUsername.Location = new System.Drawing.Point(16, 41);
            this.txtAdminUserAddUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdminUserAddUsername.Name = "txtAdminUserAddUsername";
            this.txtAdminUserAddUsername.Size = new System.Drawing.Size(327, 22);
            this.txtAdminUserAddUsername.TabIndex = 8;
            // 
            // lblAdminUserAddUsername
            // 
            this.lblAdminUserAddUsername.AutoSize = true;
            this.lblAdminUserAddUsername.Location = new System.Drawing.Point(15, 11);
            this.lblAdminUserAddUsername.Name = "lblAdminUserAddUsername";
            this.lblAdminUserAddUsername.Size = new System.Drawing.Size(117, 16);
            this.lblAdminUserAddUsername.TabIndex = 7;
            this.lblAdminUserAddUsername.Text = "Uživatelské jméno";
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
            // lblAdminUserAddRoles
            // 
            this.lblAdminUserAddRoles.AutoSize = true;
            this.lblAdminUserAddRoles.Location = new System.Drawing.Point(15, 154);
            this.lblAdminUserAddRoles.Name = "lblAdminUserAddRoles";
            this.lblAdminUserAddRoles.Size = new System.Drawing.Size(36, 16);
            this.lblAdminUserAddRoles.TabIndex = 13;
            this.lblAdminUserAddRoles.Text = "Role";
            // 
            // AdminUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 271);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.lblAdminUserAddRoles);
            this.Controls.Add(this.cboEmployees);
            this.Controls.Add(this.btnAdminEditOK);
            this.Controls.Add(this.lblAdminUserAddEmployee);
            this.Controls.Add(this.txtAdminUserAddUsername);
            this.Controls.Add(this.lblAdminUserAddUsername);
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
        private System.Windows.Forms.Label lblAdminUserAddEmployee;
        private System.Windows.Forms.TextBox txtAdminUserAddUsername;
        private System.Windows.Forms.Label lblAdminUserAddUsername;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Label lblAdminUserAddRoles;
    }
}