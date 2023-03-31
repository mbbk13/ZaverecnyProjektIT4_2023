namespace Projekt
{
    partial class AdminWorkTypeEdit
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
            this.txtAdminWorkTypeEditDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdminWorkTypeEditDescription = new System.Windows.Forms.Label();
            this.txtAdminWorkTypeEditName = new System.Windows.Forms.TextBox();
            this.lblAdminWorkTypeEditName = new System.Windows.Forms.Label();
            this.btnAdminWorkTypeEditOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdminWorkTypeEditDescription
            // 
            this.txtAdminWorkTypeEditDescription.Location = new System.Drawing.Point(11, 87);
            this.txtAdminWorkTypeEditDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminWorkTypeEditDescription.MaxLength = 200;
            this.txtAdminWorkTypeEditDescription.Name = "txtAdminWorkTypeEditDescription";
            this.txtAdminWorkTypeEditDescription.Size = new System.Drawing.Size(234, 89);
            this.txtAdminWorkTypeEditDescription.TabIndex = 8;
            this.txtAdminWorkTypeEditDescription.Text = "";
            // 
            // lblAdminWorkTypeEditDescription
            // 
            this.lblAdminWorkTypeEditDescription.AutoSize = true;
            this.lblAdminWorkTypeEditDescription.Location = new System.Drawing.Point(9, 63);
            this.lblAdminWorkTypeEditDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminWorkTypeEditDescription.Name = "lblAdminWorkTypeEditDescription";
            this.lblAdminWorkTypeEditDescription.Size = new System.Drawing.Size(156, 13);
            this.lblAdminWorkTypeEditDescription.TabIndex = 7;
            this.lblAdminWorkTypeEditDescription.Text = "Popis zakázky (max 200 znaků)";
            // 
            // txtAdminWorkTypeEditName
            // 
            this.txtAdminWorkTypeEditName.Location = new System.Drawing.Point(11, 31);
            this.txtAdminWorkTypeEditName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminWorkTypeEditName.Name = "txtAdminWorkTypeEditName";
            this.txtAdminWorkTypeEditName.Size = new System.Drawing.Size(234, 20);
            this.txtAdminWorkTypeEditName.TabIndex = 6;
            // 
            // lblAdminWorkTypeEditName
            // 
            this.lblAdminWorkTypeEditName.AutoSize = true;
            this.lblAdminWorkTypeEditName.Location = new System.Drawing.Point(9, 7);
            this.lblAdminWorkTypeEditName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminWorkTypeEditName.Name = "lblAdminWorkTypeEditName";
            this.lblAdminWorkTypeEditName.Size = new System.Drawing.Size(91, 13);
            this.lblAdminWorkTypeEditName.TabIndex = 5;
            this.lblAdminWorkTypeEditName.Text = "Název typu práce";
            // 
            // btnAdminWorkTypeEditOK
            // 
            this.btnAdminWorkTypeEditOK.Location = new System.Drawing.Point(188, 189);
            this.btnAdminWorkTypeEditOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminWorkTypeEditOK.Name = "btnAdminWorkTypeEditOK";
            this.btnAdminWorkTypeEditOK.Size = new System.Drawing.Size(56, 26);
            this.btnAdminWorkTypeEditOK.TabIndex = 9;
            this.btnAdminWorkTypeEditOK.Text = "OK";
            this.btnAdminWorkTypeEditOK.UseVisualStyleBackColor = true;
            this.btnAdminWorkTypeEditOK.Click += new System.EventHandler(this.btnAdminWorkTypeEditOK_Click);
            // 
            // AdminWorkTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 225);
            this.Controls.Add(this.btnAdminWorkTypeEditOK);
            this.Controls.Add(this.txtAdminWorkTypeEditDescription);
            this.Controls.Add(this.lblAdminWorkTypeEditDescription);
            this.Controls.Add(this.txtAdminWorkTypeEditName);
            this.Controls.Add(this.lblAdminWorkTypeEditName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminWorkTypeEdit";
            this.Text = "Editace typu práce";
            this.Load += new System.EventHandler(this.AdminWorkTypeEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAdminWorkTypeEditDescription;
        private System.Windows.Forms.Label lblAdminWorkTypeEditDescription;
        private System.Windows.Forms.TextBox txtAdminWorkTypeEditName;
        private System.Windows.Forms.Label lblAdminWorkTypeEditName;
        private System.Windows.Forms.Button btnAdminWorkTypeEditOK;
    }
}