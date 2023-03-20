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
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(12, 86);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(225, 21);
            this.cboEmployees.TabIndex = 12;
            // 
            // btnAdminEditOK
            // 
            this.btnAdminEditOK.Location = new System.Drawing.Point(138, 185);
            this.btnAdminEditOK.Name = "btnAdminEditOK";
            this.btnAdminEditOK.Size = new System.Drawing.Size(100, 23);
            this.btnAdminEditOK.TabIndex = 11;
            this.btnAdminEditOK.Text = "OK";
            this.btnAdminEditOK.UseVisualStyleBackColor = true;
            // 
            // lblAdminAddEmployee
            // 
            this.lblAdminAddEmployee.AutoSize = true;
            this.lblAdminAddEmployee.Location = new System.Drawing.Point(11, 69);
            this.lblAdminAddEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminAddEmployee.Name = "lblAdminAddEmployee";
            this.lblAdminAddEmployee.Size = new System.Drawing.Size(72, 13);
            this.lblAdminAddEmployee.TabIndex = 9;
            this.lblAdminAddEmployee.Text = "Zaměstnanec";
            // 
            // txtAdminAddUsername
            // 
            this.txtAdminAddUsername.Location = new System.Drawing.Point(12, 33);
            this.txtAdminAddUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdminAddUsername.Name = "txtAdminAddUsername";
            this.txtAdminAddUsername.Size = new System.Drawing.Size(226, 20);
            this.txtAdminAddUsername.TabIndex = 8;
            // 
            // lblAdminAddUsername
            // 
            this.lblAdminAddUsername.AutoSize = true;
            this.lblAdminAddUsername.Location = new System.Drawing.Point(11, 9);
            this.lblAdminAddUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminAddUsername.Name = "lblAdminAddUsername";
            this.lblAdminAddUsername.Size = new System.Drawing.Size(93, 13);
            this.lblAdminAddUsername.TabIndex = 7;
            this.lblAdminAddUsername.Text = "Uživatelské jméno";
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(12, 142);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(225, 21);
            this.cboRoles.TabIndex = 14;
            // 
            // lblAdminAddRoles
            // 
            this.lblAdminAddRoles.AutoSize = true;
            this.lblAdminAddRoles.Location = new System.Drawing.Point(11, 125);
            this.lblAdminAddRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminAddRoles.Name = "lblAdminAddRoles";
            this.lblAdminAddRoles.Size = new System.Drawing.Size(29, 13);
            this.lblAdminAddRoles.TabIndex = 13;
            this.lblAdminAddRoles.Text = "Role";
            // 
            // AdminUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 220);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.lblAdminAddRoles);
            this.Controls.Add(this.cboEmployees);
            this.Controls.Add(this.btnAdminEditOK);
            this.Controls.Add(this.lblAdminAddEmployee);
            this.Controls.Add(this.txtAdminAddUsername);
            this.Controls.Add(this.lblAdminAddUsername);
            this.MinimumSize = new System.Drawing.Size(264, 259);
            this.Name = "AdminUserAdd";
            this.Text = "Přidávání uživatele";
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