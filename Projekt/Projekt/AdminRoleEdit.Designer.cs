namespace Projekt
{
    partial class AdminRoleEdit
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
            this.lblAdminRoleEditName = new System.Windows.Forms.Label();
            this.txtAdminRoleEditName = new System.Windows.Forms.TextBox();
            this.btnAdminRoleEditOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminRoleEditName
            // 
            this.lblAdminRoleEditName.AutoSize = true;
            this.lblAdminRoleEditName.Location = new System.Drawing.Point(13, 13);
            this.lblAdminRoleEditName.Name = "lblAdminRoleEditName";
            this.lblAdminRoleEditName.Size = new System.Drawing.Size(72, 16);
            this.lblAdminRoleEditName.TabIndex = 0;
            this.lblAdminRoleEditName.Text = "Název role";
            // 
            // txtAdminRoleEditName
            // 
            this.txtAdminRoleEditName.Location = new System.Drawing.Point(16, 32);
            this.txtAdminRoleEditName.Name = "txtAdminRoleEditName";
            this.txtAdminRoleEditName.Size = new System.Drawing.Size(237, 22);
            this.txtAdminRoleEditName.TabIndex = 1;
            // 
            // btnAdminRoleEditOK
            // 
            this.btnAdminRoleEditOK.Location = new System.Drawing.Point(178, 72);
            this.btnAdminRoleEditOK.Name = "btnAdminRoleEditOK";
            this.btnAdminRoleEditOK.Size = new System.Drawing.Size(75, 23);
            this.btnAdminRoleEditOK.TabIndex = 2;
            this.btnAdminRoleEditOK.Text = "OK";
            this.btnAdminRoleEditOK.UseVisualStyleBackColor = true;
            this.btnAdminRoleEditOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminRoleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 107);
            this.Controls.Add(this.btnAdminRoleEditOK);
            this.Controls.Add(this.txtAdminRoleEditName);
            this.Controls.Add(this.lblAdminRoleEditName);
            this.Name = "AdminRoleEdit";
            this.Text = "Editace role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminRoleEditName;
        private System.Windows.Forms.TextBox txtAdminRoleEditName;
        private System.Windows.Forms.Button btnAdminRoleEditOK;
    }
}