namespace Projekt
{
    partial class AdminUserEdit
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
            this.lblAdminEditUsername = new System.Windows.Forms.Label();
            this.txtAdminEditUsername = new System.Windows.Forms.TextBox();
            this.lblAdminEditRole = new System.Windows.Forms.Label();
            this.btnAdminEditResetPassword = new System.Windows.Forms.Button();
            this.btnAdminEditOK = new System.Windows.Forms.Button();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAdminEditUsername
            // 
            this.lblAdminEditUsername.AutoSize = true;
            this.lblAdminEditUsername.Location = new System.Drawing.Point(9, 7);
            this.lblAdminEditUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminEditUsername.Name = "lblAdminEditUsername";
            this.lblAdminEditUsername.Size = new System.Drawing.Size(93, 13);
            this.lblAdminEditUsername.TabIndex = 0;
            this.lblAdminEditUsername.Text = "Uživatelské jméno";
            // 
            // txtAdminEditUsername
            // 
            this.txtAdminEditUsername.Location = new System.Drawing.Point(10, 31);
            this.txtAdminEditUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdminEditUsername.Name = "txtAdminEditUsername";
            this.txtAdminEditUsername.Size = new System.Drawing.Size(226, 20);
            this.txtAdminEditUsername.TabIndex = 1;
            // 
            // lblAdminEditRole
            // 
            this.lblAdminEditRole.AutoSize = true;
            this.lblAdminEditRole.Location = new System.Drawing.Point(9, 67);
            this.lblAdminEditRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminEditRole.Name = "lblAdminEditRole";
            this.lblAdminEditRole.Size = new System.Drawing.Size(29, 13);
            this.lblAdminEditRole.TabIndex = 2;
            this.lblAdminEditRole.Text = "Role";
            // 
            // btnAdminEditResetPassword
            // 
            this.btnAdminEditResetPassword.Location = new System.Drawing.Point(10, 134);
            this.btnAdminEditResetPassword.Name = "btnAdminEditResetPassword";
            this.btnAdminEditResetPassword.Size = new System.Drawing.Size(100, 23);
            this.btnAdminEditResetPassword.TabIndex = 4;
            this.btnAdminEditResetPassword.Text = "Reset password";
            this.btnAdminEditResetPassword.UseVisualStyleBackColor = true;
            this.btnAdminEditResetPassword.Click += new System.EventHandler(this.btnAdminEditResetPassword_Click);
            // 
            // btnAdminEditOK
            // 
            this.btnAdminEditOK.Location = new System.Drawing.Point(136, 134);
            this.btnAdminEditOK.Name = "btnAdminEditOK";
            this.btnAdminEditOK.Size = new System.Drawing.Size(100, 23);
            this.btnAdminEditOK.TabIndex = 5;
            this.btnAdminEditOK.Text = "OK";
            this.btnAdminEditOK.UseVisualStyleBackColor = true;
            this.btnAdminEditOK.Click += new System.EventHandler(this.btnAdminEditOK_Click);
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(10, 84);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(225, 21);
            this.cboRoles.TabIndex = 6;
            // 
            // AdminUsersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 169);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.btnAdminEditOK);
            this.Controls.Add(this.btnAdminEditResetPassword);
            this.Controls.Add(this.lblAdminEditRole);
            this.Controls.Add(this.txtAdminEditUsername);
            this.Controls.Add(this.lblAdminEditUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(237, 208);
            this.Name = "AdminUsersEdit";
            this.Text = "Editace uživatele";
            this.Load += new System.EventHandler(this.AdminUsersEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminEditUsername;
        private System.Windows.Forms.TextBox txtAdminEditUsername;
        private System.Windows.Forms.Label lblAdminEditRole;
        private System.Windows.Forms.Button btnAdminEditResetPassword;
        private System.Windows.Forms.Button btnAdminEditOK;
        private System.Windows.Forms.ComboBox cboRoles;
    }
}