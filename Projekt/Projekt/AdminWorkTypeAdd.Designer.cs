namespace Projekt
{
    partial class AdminWorkTypeAdd
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
            this.btnAdmiWorkTypeAddOK = new System.Windows.Forms.Button();
            this.txtAdminWorkTypeAddDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdminWorkTypeAddDescription = new System.Windows.Forms.Label();
            this.txtAdminWorkTypeAddName = new System.Windows.Forms.TextBox();
            this.lblAdminWorkTypeAddName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmiWorkTypeAddOK
            // 
            this.btnAdmiWorkTypeAddOK.Location = new System.Drawing.Point(190, 193);
            this.btnAdmiWorkTypeAddOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmiWorkTypeAddOK.Name = "btnAdmiWorkTypeAddOK";
            this.btnAdmiWorkTypeAddOK.Size = new System.Drawing.Size(56, 26);
            this.btnAdmiWorkTypeAddOK.TabIndex = 15;
            this.btnAdmiWorkTypeAddOK.Text = "OK";
            this.btnAdmiWorkTypeAddOK.UseVisualStyleBackColor = true;
            this.btnAdmiWorkTypeAddOK.Click += new System.EventHandler(this.btnAdmiWorkTypeAddOK_Click);
            // 
            // txtAdminWorkTypeAddDescription
            // 
            this.txtAdminWorkTypeAddDescription.Location = new System.Drawing.Point(13, 90);
            this.txtAdminWorkTypeAddDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminWorkTypeAddDescription.MaxLength = 200;
            this.txtAdminWorkTypeAddDescription.Name = "txtAdminWorkTypeAddDescription";
            this.txtAdminWorkTypeAddDescription.Size = new System.Drawing.Size(234, 89);
            this.txtAdminWorkTypeAddDescription.TabIndex = 14;
            this.txtAdminWorkTypeAddDescription.Text = "";
            // 
            // lblAdminWorkTypeAddDescription
            // 
            this.lblAdminWorkTypeAddDescription.AutoSize = true;
            this.lblAdminWorkTypeAddDescription.Location = new System.Drawing.Point(10, 66);
            this.lblAdminWorkTypeAddDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminWorkTypeAddDescription.Name = "lblAdminWorkTypeAddDescription";
            this.lblAdminWorkTypeAddDescription.Size = new System.Drawing.Size(156, 13);
            this.lblAdminWorkTypeAddDescription.TabIndex = 13;
            this.lblAdminWorkTypeAddDescription.Text = "Popis zakázky (max 200 znaků)";
            // 
            // txtAdminWorkTypeAddName
            // 
            this.txtAdminWorkTypeAddName.Location = new System.Drawing.Point(13, 34);
            this.txtAdminWorkTypeAddName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminWorkTypeAddName.Name = "txtAdminWorkTypeAddName";
            this.txtAdminWorkTypeAddName.Size = new System.Drawing.Size(234, 20);
            this.txtAdminWorkTypeAddName.TabIndex = 12;
            // 
            // lblAdminWorkTypeAddName
            // 
            this.lblAdminWorkTypeAddName.AutoSize = true;
            this.lblAdminWorkTypeAddName.Location = new System.Drawing.Point(10, 11);
            this.lblAdminWorkTypeAddName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminWorkTypeAddName.Name = "lblAdminWorkTypeAddName";
            this.lblAdminWorkTypeAddName.Size = new System.Drawing.Size(91, 13);
            this.lblAdminWorkTypeAddName.TabIndex = 11;
            this.lblAdminWorkTypeAddName.Text = "Název typu práce";
            // 
            // AdminWorkTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 229);
            this.Controls.Add(this.btnAdmiWorkTypeAddOK);
            this.Controls.Add(this.txtAdminWorkTypeAddDescription);
            this.Controls.Add(this.lblAdminWorkTypeAddDescription);
            this.Controls.Add(this.txtAdminWorkTypeAddName);
            this.Controls.Add(this.lblAdminWorkTypeAddName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminWorkTypeAdd";
            this.Text = "Přidávání typu práce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmiWorkTypeAddOK;
        private System.Windows.Forms.RichTextBox txtAdminWorkTypeAddDescription;
        private System.Windows.Forms.Label lblAdminWorkTypeAddDescription;
        private System.Windows.Forms.TextBox txtAdminWorkTypeAddName;
        private System.Windows.Forms.Label lblAdminWorkTypeAddName;
    }
}