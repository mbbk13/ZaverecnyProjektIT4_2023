namespace Projekt
{
    partial class AdminRoleAdd
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
            this.btnAdminRoleAddOK = new System.Windows.Forms.Button();
            this.txtAdminRoleAddName = new System.Windows.Forms.TextBox();
            this.lblAdminRoleAddName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminRoleAddOK
            // 
            this.btnAdminRoleAddOK.Location = new System.Drawing.Point(208, 71);
            this.btnAdminRoleAddOK.Name = "btnAdminRoleAddOK";
            this.btnAdminRoleAddOK.Size = new System.Drawing.Size(75, 23);
            this.btnAdminRoleAddOK.TabIndex = 5;
            this.btnAdminRoleAddOK.Text = "OK";
            this.btnAdminRoleAddOK.UseVisualStyleBackColor = true;
            this.btnAdminRoleAddOK.Click += new System.EventHandler(this.btnAdminRoleAddOK_Click);
            // 
            // txtAdminRoleAddName
            // 
            this.txtAdminRoleAddName.Location = new System.Drawing.Point(15, 28);
            this.txtAdminRoleAddName.Name = "txtAdminRoleAddName";
            this.txtAdminRoleAddName.Size = new System.Drawing.Size(268, 22);
            this.txtAdminRoleAddName.TabIndex = 4;
            // 
            // lblAdminRoleAddName
            // 
            this.lblAdminRoleAddName.AutoSize = true;
            this.lblAdminRoleAddName.Location = new System.Drawing.Point(12, 9);
            this.lblAdminRoleAddName.Name = "lblAdminRoleAddName";
            this.lblAdminRoleAddName.Size = new System.Drawing.Size(72, 16);
            this.lblAdminRoleAddName.TabIndex = 3;
            this.lblAdminRoleAddName.Text = "Název role";
            // 
            // AdminRoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 106);
            this.Controls.Add(this.btnAdminRoleAddOK);
            this.Controls.Add(this.txtAdminRoleAddName);
            this.Controls.Add(this.lblAdminRoleAddName);
            this.Name = "AdminRoleAdd";
            this.Text = "Přidávání nové role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminRoleAddOK;
        private System.Windows.Forms.TextBox txtAdminRoleAddName;
        private System.Windows.Forms.Label lblAdminRoleAddName;
    }
}