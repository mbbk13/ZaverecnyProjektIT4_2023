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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(153, 201);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtChangePassword1
            // 
            this.txtChangePassword1.Location = new System.Drawing.Point(15, 97);
            this.txtChangePassword1.Name = "txtChangePassword1";
            this.txtChangePassword1.PasswordChar = '۩';
            this.txtChangePassword1.Size = new System.Drawing.Size(213, 20);
            this.txtChangePassword1.TabIndex = 1;
            // 
            // lblChangePassword1
            // 
            this.lblChangePassword1.AutoSize = true;
            this.lblChangePassword1.Location = new System.Drawing.Point(12, 71);
            this.lblChangePassword1.Name = "lblChangePassword1";
            this.lblChangePassword1.Size = new System.Drawing.Size(34, 13);
            this.lblChangePassword1.TabIndex = 7;
            this.lblChangePassword1.Text = "Heslo";
            // 
            // txtChangePassword2
            // 
            this.txtChangePassword2.Location = new System.Drawing.Point(16, 163);
            this.txtChangePassword2.Name = "txtChangePassword2";
            this.txtChangePassword2.PasswordChar = '۩';
            this.txtChangePassword2.Size = new System.Drawing.Size(212, 20);
            this.txtChangePassword2.TabIndex = 2;
            // 
            // lblChangePassword2
            // 
            this.lblChangePassword2.AutoSize = true;
            this.lblChangePassword2.Location = new System.Drawing.Point(13, 137);
            this.lblChangePassword2.Name = "lblChangePassword2";
            this.lblChangePassword2.Size = new System.Drawing.Size(66, 13);
            this.lblChangePassword2.TabIndex = 10;
            this.lblChangePassword2.Text = "Heslo znovu";
            // 
            // txtChangePasswordUsername
            // 
            this.txtChangePasswordUsername.Location = new System.Drawing.Point(15, 35);
            this.txtChangePasswordUsername.Name = "txtChangePasswordUsername";
            this.txtChangePasswordUsername.PasswordChar = '۩';
            this.txtChangePasswordUsername.Size = new System.Drawing.Size(213, 20);
            this.txtChangePasswordUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Uživatelské jméno";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 236);
            this.Controls.Add(this.txtChangePasswordUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChangePassword2);
            this.Controls.Add(this.lblChangePassword2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtChangePassword1);
            this.Controls.Add(this.lblChangePassword1);
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
        private System.Windows.Forms.Label label1;
    }
}