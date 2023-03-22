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
            this.lblAdminEditUsername.Location = new System.Drawing.Point(12, 9);
            this.lblAdminEditUsername.Name = "lblAdminEditUsername";
            this.lblAdminEditUsername.Size = new System.Drawing.Size(117, 16);
            this.lblAdminEditUsername.TabIndex = 0;
            this.lblAdminEditUsername.Text = "Uživatelské jméno";
            // 
            // txtAdminEditUsername
            // 
            this.txtAdminEditUsername.Location = new System.Drawing.Point(13, 38);
            this.txtAdminEditUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdminEditUsername.Name = "txtAdminEditUsername";
            this.txtAdminEditUsername.Size = new System.Drawing.Size(300, 22);
            this.txtAdminEditUsername.TabIndex = 1;
            // 
            // lblAdminEditRole
            // 
            this.lblAdminEditRole.AutoSize = true;
            this.lblAdminEditRole.Location = new System.Drawing.Point(12, 82);
            this.lblAdminEditRole.Name = "lblAdminEditRole";
            this.lblAdminEditRole.Size = new System.Drawing.Size(36, 16);
            this.lblAdminEditRole.TabIndex = 2;
            this.lblAdminEditRole.Text = "Role";
            // 
            // btnAdminEditResetPassword
            // 
            this.btnAdminEditResetPassword.Location = new System.Drawing.Point(13, 165);
            this.btnAdminEditResetPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminEditResetPassword.Name = "btnAdminEditResetPassword";
            this.btnAdminEditResetPassword.Size = new System.Drawing.Size(133, 28);
            this.btnAdminEditResetPassword.TabIndex = 4;
            this.btnAdminEditResetPassword.Text = "Reset password";
            this.btnAdminEditResetPassword.UseVisualStyleBackColor = true;
            this.btnAdminEditResetPassword.Click += new System.EventHandler(this.btnAdminEditResetPassword_Click);
            // 
            // btnAdminEditOK
            // 
            this.btnAdminEditOK.Location = new System.Drawing.Point(181, 165);
            this.btnAdminEditOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminEditOK.Name = "btnAdminEditOK";
            this.btnAdminEditOK.Size = new System.Drawing.Size(133, 28);
            this.btnAdminEditOK.TabIndex = 5;
            this.btnAdminEditOK.Text = "OK";
            this.btnAdminEditOK.UseVisualStyleBackColor = true;
            this.btnAdminEditOK.Click += new System.EventHandler(this.btnAdminEditOK_Click);
            // 
            // cboRoles
            // 
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(13, 103);
            this.cboRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(299, 24);
            this.cboRoles.TabIndex = 6;
            // 
            // AdminUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 208);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.btnAdminEditOK);
            this.Controls.Add(this.btnAdminEditResetPassword);
            this.Controls.Add(this.lblAdminEditRole);
            this.Controls.Add(this.txtAdminEditUsername);
            this.Controls.Add(this.lblAdminEditUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(310, 245);
            this.Name = "AdminUserEdit";
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