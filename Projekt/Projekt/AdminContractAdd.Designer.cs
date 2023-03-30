namespace Projekt
{
    partial class AdminContractAdd
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
            this.btnAdminContractAddOK = new System.Windows.Forms.Button();
            this.txtAdminContractAddDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdminContractAddDescription = new System.Windows.Forms.Label();
            this.txtAdminContractorAddName = new System.Windows.Forms.TextBox();
            this.lblAdminContractorAddName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminContractAddOK
            // 
            this.btnAdminContractAddOK.Location = new System.Drawing.Point(251, 234);
            this.btnAdminContractAddOK.Name = "btnAdminContractAddOK";
            this.btnAdminContractAddOK.Size = new System.Drawing.Size(75, 32);
            this.btnAdminContractAddOK.TabIndex = 10;
            this.btnAdminContractAddOK.Text = "OK";
            this.btnAdminContractAddOK.UseVisualStyleBackColor = true;
            this.btnAdminContractAddOK.Click += new System.EventHandler(this.btnAdminContractAddOK_Click);
            // 
            // txtAdminContractAddDescription
            // 
            this.txtAdminContractAddDescription.Location = new System.Drawing.Point(15, 107);
            this.txtAdminContractAddDescription.Name = "txtAdminContractAddDescription";
            this.txtAdminContractAddDescription.Size = new System.Drawing.Size(311, 109);
            this.txtAdminContractAddDescription.TabIndex = 9;
            this.txtAdminContractAddDescription.Text = "";
            // 
            // lblAdminContractAddDescription
            // 
            this.lblAdminContractAddDescription.AutoSize = true;
            this.lblAdminContractAddDescription.Location = new System.Drawing.Point(12, 77);
            this.lblAdminContractAddDescription.Name = "lblAdminContractAddDescription";
            this.lblAdminContractAddDescription.Size = new System.Drawing.Size(94, 16);
            this.lblAdminContractAddDescription.TabIndex = 8;
            this.lblAdminContractAddDescription.Text = "Popis zakázky";
            // 
            // txtAdminContractorAddName
            // 
            this.txtAdminContractorAddName.Location = new System.Drawing.Point(15, 38);
            this.txtAdminContractorAddName.Name = "txtAdminContractorAddName";
            this.txtAdminContractorAddName.Size = new System.Drawing.Size(311, 22);
            this.txtAdminContractorAddName.TabIndex = 7;
            // 
            // lblAdminContractorAddName
            // 
            this.lblAdminContractorAddName.AutoSize = true;
            this.lblAdminContractorAddName.Location = new System.Drawing.Point(12, 9);
            this.lblAdminContractorAddName.Name = "lblAdminContractorAddName";
            this.lblAdminContractorAddName.Size = new System.Drawing.Size(116, 16);
            this.lblAdminContractorAddName.TabIndex = 6;
            this.lblAdminContractorAddName.Text = "Název zadavatele";
            // 
            // AdminContractAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 282);
            this.Controls.Add(this.btnAdminContractAddOK);
            this.Controls.Add(this.txtAdminContractAddDescription);
            this.Controls.Add(this.lblAdminContractAddDescription);
            this.Controls.Add(this.txtAdminContractorAddName);
            this.Controls.Add(this.lblAdminContractorAddName);
            this.Name = "AdminContractAdd";
            this.Text = "Přidávání zakázky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminContractAddOK;
        private System.Windows.Forms.RichTextBox txtAdminContractAddDescription;
        private System.Windows.Forms.Label lblAdminContractAddDescription;
        private System.Windows.Forms.TextBox txtAdminContractorAddName;
        private System.Windows.Forms.Label lblAdminContractorAddName;
    }
}