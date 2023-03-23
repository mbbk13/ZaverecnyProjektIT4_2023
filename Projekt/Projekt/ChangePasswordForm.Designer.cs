namespace Projekt
{
    partial class ChangePasswordForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtChangePassword1 = new System.Windows.Forms.TextBox();
            this.lblChangePassword1 = new System.Windows.Forms.Label();
            this.txtChangePassword2 = new System.Windows.Forms.TextBox();
            this.lblChangePassword2 = new System.Windows.Forms.Label();
            this.txtChangePasswordUsername = new System.Windows.Forms.TextBox();
            this.lblChangePasswordUserName = new System.Windows.Forms.Label();
            this.txtChangePasswordCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblChangePasswordCurrentPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(204, 330);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtChangePassword1
            // 
            this.txtChangePassword1.Location = new System.Drawing.Point(20, 199);
            this.txtChangePassword1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChangePassword1.Name = "txtChangePassword1";
            this.txtChangePassword1.PasswordChar = '۩';
            this.txtChangePassword1.Size = new System.Drawing.Size(283, 22);
            this.txtChangePassword1.TabIndex = 2;
            // 
            // lblChangePassword1
            // 
            this.lblChangePassword1.AutoSize = true;
            this.lblChangePassword1.Location = new System.Drawing.Point(16, 167);
            this.lblChangePassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangePassword1.Name = "lblChangePassword1";
            this.lblChangePassword1.Size = new System.Drawing.Size(43, 16);
            this.lblChangePassword1.TabIndex = 7;
            this.lblChangePassword1.Text = "Heslo";
            // 
            // txtChangePassword2
            // 
            this.txtChangePassword2.Location = new System.Drawing.Point(21, 281);
            this.txtChangePassword2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChangePassword2.Name = "txtChangePassword2";
            this.txtChangePassword2.PasswordChar = '۩';
            this.txtChangePassword2.Size = new System.Drawing.Size(281, 22);
            this.txtChangePassword2.TabIndex = 3;
            // 
            // lblChangePassword2
            // 
            this.lblChangePassword2.AutoSize = true;
            this.lblChangePassword2.Location = new System.Drawing.Point(17, 249);
            this.lblChangePassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangePassword2.Name = "lblChangePassword2";
            this.lblChangePassword2.Size = new System.Drawing.Size(81, 16);
            this.lblChangePassword2.TabIndex = 10;
            this.lblChangePassword2.Text = "Heslo znovu";
            // 
            // txtChangePasswordUsername
            // 
            this.txtChangePasswordUsername.Location = new System.Drawing.Point(20, 43);
            this.txtChangePasswordUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChangePasswordUsername.Name = "txtChangePasswordUsername";
            this.txtChangePasswordUsername.Size = new System.Drawing.Size(283, 22);
            this.txtChangePasswordUsername.TabIndex = 0;
            // 
            // lblChangePasswordUserName
            // 
            this.lblChangePasswordUserName.AutoSize = true;
            this.lblChangePasswordUserName.Location = new System.Drawing.Point(16, 11);
            this.lblChangePasswordUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangePasswordUserName.Name = "lblChangePasswordUserName";
            this.lblChangePasswordUserName.Size = new System.Drawing.Size(117, 16);
            this.lblChangePasswordUserName.TabIndex = 12;
            this.lblChangePasswordUserName.Text = "Uživatelské jméno";
            // 
            // txtChangePasswordCurrentPassword
            // 
            this.txtChangePasswordCurrentPassword.Location = new System.Drawing.Point(20, 118);
            this.txtChangePasswordCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChangePasswordCurrentPassword.Name = "txtChangePasswordCurrentPassword";
            this.txtChangePasswordCurrentPassword.PasswordChar = '۩';
            this.txtChangePasswordCurrentPassword.Size = new System.Drawing.Size(283, 22);
            this.txtChangePasswordCurrentPassword.TabIndex = 1;
            // 
            // lblChangePasswordCurrentPassword
            // 
            this.lblChangePasswordCurrentPassword.AutoSize = true;
            this.lblChangePasswordCurrentPassword.Location = new System.Drawing.Point(16, 86);
            this.lblChangePasswordCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangePasswordCurrentPassword.Name = "lblChangePasswordCurrentPassword";
            this.lblChangePasswordCurrentPassword.Size = new System.Drawing.Size(90, 16);
            this.lblChangePasswordCurrentPassword.TabIndex = 14;
            this.lblChangePasswordCurrentPassword.Text = "Aktuální heslo";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 373);
            this.Controls.Add(this.txtChangePasswordCurrentPassword);
            this.Controls.Add(this.lblChangePasswordCurrentPassword);
            this.Controls.Add(this.txtChangePasswordUsername);
            this.Controls.Add(this.lblChangePasswordUserName);
            this.Controls.Add(this.txtChangePassword2);
            this.Controls.Add(this.lblChangePassword2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtChangePassword1);
            this.Controls.Add(this.lblChangePassword1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePasswordForm";
            this.Text = "Změna hesla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtChangePassword1;
        private System.Windows.Forms.Label lblChangePassword1;
        private System.Windows.Forms.TextBox txtChangePassword2;
        private System.Windows.Forms.Label lblChangePassword2;
        private System.Windows.Forms.TextBox txtChangePasswordUsername;
        private System.Windows.Forms.Label lblChangePasswordUserName;
        private System.Windows.Forms.TextBox txtChangePasswordCurrentPassword;
        private System.Windows.Forms.Label lblChangePasswordCurrentPassword;
    }
}