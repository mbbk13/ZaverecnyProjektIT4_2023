namespace Projekt
{
    partial class AdminUsersEdit
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
            this.txtAdminEditUsername.Name = "txtAdminEditUsername";
            this.txtAdminEditUsername.Size = new System.Drawing.Size(146, 22);
            this.txtAdminEditUsername.TabIndex = 1;
            // 
            // AdminUsersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 256);
            this.Controls.Add(this.txtAdminEditUsername);
            this.Controls.Add(this.lblAdminEditUsername);
            this.Name = "AdminUsersEdit";
            this.Text = "Editace uživatele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminEditUsername;
        private System.Windows.Forms.TextBox txtAdminEditUsername;
    }
}