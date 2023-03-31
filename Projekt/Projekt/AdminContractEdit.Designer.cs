namespace Projekt
{
    partial class AdminContractEdit
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
            this.lblAdminContractEditName = new System.Windows.Forms.Label();
            this.txtAdminContractEditName = new System.Windows.Forms.TextBox();
            this.lblAdminContractEditDescription = new System.Windows.Forms.Label();
            this.txtAdminContractEditDescription = new System.Windows.Forms.RichTextBox();
            this.btnAdminContractEditOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminContractEditName
            // 
            this.lblAdminContractEditName.AutoSize = true;
            this.lblAdminContractEditName.Location = new System.Drawing.Point(9, 7);
            this.lblAdminContractEditName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminContractEditName.Name = "lblAdminContractEditName";
            this.lblAdminContractEditName.Size = new System.Drawing.Size(93, 13);
            this.lblAdminContractEditName.TabIndex = 0;
            this.lblAdminContractEditName.Text = "Název zadavatele";
            // 
            // txtAdminContractEditName
            // 
            this.txtAdminContractEditName.Location = new System.Drawing.Point(11, 31);
            this.txtAdminContractEditName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminContractEditName.Name = "txtAdminContractEditName";
            this.txtAdminContractEditName.Size = new System.Drawing.Size(234, 20);
            this.txtAdminContractEditName.TabIndex = 1;
            // 
            // lblAdminContractEditDescription
            // 
            this.lblAdminContractEditDescription.AutoSize = true;
            this.lblAdminContractEditDescription.Location = new System.Drawing.Point(9, 63);
            this.lblAdminContractEditDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminContractEditDescription.Name = "lblAdminContractEditDescription";
            this.lblAdminContractEditDescription.Size = new System.Drawing.Size(156, 13);
            this.lblAdminContractEditDescription.TabIndex = 2;
            this.lblAdminContractEditDescription.Text = "Popis zakázky (max 200 znaků)";
            // 
            // txtAdminContractEditDescription
            // 
            this.txtAdminContractEditDescription.Location = new System.Drawing.Point(11, 87);
            this.txtAdminContractEditDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminContractEditDescription.MaxLength = 200;
            this.txtAdminContractEditDescription.Name = "txtAdminContractEditDescription";
            this.txtAdminContractEditDescription.Size = new System.Drawing.Size(234, 89);
            this.txtAdminContractEditDescription.TabIndex = 4;
            this.txtAdminContractEditDescription.Text = "";
            // 
            // btnAdminContractEditOK
            // 
            this.btnAdminContractEditOK.Location = new System.Drawing.Point(188, 190);
            this.btnAdminContractEditOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminContractEditOK.Name = "btnAdminContractEditOK";
            this.btnAdminContractEditOK.Size = new System.Drawing.Size(56, 26);
            this.btnAdminContractEditOK.TabIndex = 5;
            this.btnAdminContractEditOK.Text = "OK";
            this.btnAdminContractEditOK.UseVisualStyleBackColor = true;
            this.btnAdminContractEditOK.Click += new System.EventHandler(this.btnAdminContractEditOK_Click);
            // 
            // AdminContractEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 225);
            this.Controls.Add(this.btnAdminContractEditOK);
            this.Controls.Add(this.txtAdminContractEditDescription);
            this.Controls.Add(this.lblAdminContractEditDescription);
            this.Controls.Add(this.txtAdminContractEditName);
            this.Controls.Add(this.lblAdminContractEditName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminContractEdit";
            this.Text = "Editace zakázky";
            this.Load += new System.EventHandler(this.AdminContractEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminContractEditName;
        private System.Windows.Forms.TextBox txtAdminContractEditName;
        private System.Windows.Forms.Label lblAdminContractEditDescription;
        private System.Windows.Forms.RichTextBox txtAdminContractEditDescription;
        private System.Windows.Forms.Button btnAdminContractEditOK;
    }
}