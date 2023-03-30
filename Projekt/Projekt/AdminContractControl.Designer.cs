namespace Projekt
{
    partial class AdminContractControl
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
            this.lvAdminContractControl = new System.Windows.Forms.ListView();
            this.chContractorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContractDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdminContractDelete = new System.Windows.Forms.Button();
            this.btnAdminContractAdd = new System.Windows.Forms.Button();
            this.btnAdminContractEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAdminContractControl
            // 
            this.lvAdminContractControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chContractorName,
            this.chContractDescription,
            this.chId});
            this.lvAdminContractControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdminContractControl.FullRowSelect = true;
            this.lvAdminContractControl.GridLines = true;
            this.lvAdminContractControl.HideSelection = false;
            this.lvAdminContractControl.Location = new System.Drawing.Point(0, 0);
            this.lvAdminContractControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdminContractControl.Name = "lvAdminContractControl";
            this.lvAdminContractControl.Size = new System.Drawing.Size(605, 450);
            this.lvAdminContractControl.TabIndex = 5;
            this.lvAdminContractControl.UseCompatibleStateImageBehavior = false;
            this.lvAdminContractControl.View = System.Windows.Forms.View.Details;
            // 
            // chContractorName
            // 
            this.chContractorName.DisplayIndex = 1;
            this.chContractorName.Text = "Název zákazníka";
            this.chContractorName.Width = 120;
            // 
            // chContractDescription
            // 
            this.chContractDescription.DisplayIndex = 2;
            this.chContractDescription.Text = "Popis zakázky";
            this.chContractDescription.Width = 300;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Identifikační č.";
            this.chId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chId.Width = 95;
            // 
            // btnAdminContractDelete
            // 
            this.btnAdminContractDelete.Image = global::Projekt.Properties.Resources.bin;
            this.btnAdminContractDelete.Location = new System.Drawing.Point(631, 95);
            this.btnAdminContractDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminContractDelete.Name = "btnAdminContractDelete";
            this.btnAdminContractDelete.Size = new System.Drawing.Size(75, 36);
            this.btnAdminContractDelete.TabIndex = 8;
            this.btnAdminContractDelete.UseVisualStyleBackColor = true;
            this.btnAdminContractDelete.Click += new System.EventHandler(this.btnAdminContractDelete_Click);
            // 
            // btnAdminContractAdd
            // 
            this.btnAdminContractAdd.Image = global::Projekt.Properties.Resources.add;
            this.btnAdminContractAdd.Location = new System.Drawing.Point(631, 53);
            this.btnAdminContractAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminContractAdd.Name = "btnAdminContractAdd";
            this.btnAdminContractAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdminContractAdd.TabIndex = 7;
            this.btnAdminContractAdd.UseVisualStyleBackColor = true;
            this.btnAdminContractAdd.Click += new System.EventHandler(this.btnAdminContractAdd_Click);
            // 
            // btnAdminContractEdit
            // 
            this.btnAdminContractEdit.Image = global::Projekt.Properties.Resources.pencil;
            this.btnAdminContractEdit.Location = new System.Drawing.Point(631, 11);
            this.btnAdminContractEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminContractEdit.Name = "btnAdminContractEdit";
            this.btnAdminContractEdit.Size = new System.Drawing.Size(75, 36);
            this.btnAdminContractEdit.TabIndex = 6;
            this.btnAdminContractEdit.UseVisualStyleBackColor = true;
            this.btnAdminContractEdit.Click += new System.EventHandler(this.btnAdminContractEdit_Click);
            // 
            // AdminContractControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btnAdminContractDelete);
            this.Controls.Add(this.btnAdminContractAdd);
            this.Controls.Add(this.btnAdminContractEdit);
            this.Controls.Add(this.lvAdminContractControl);
            this.Name = "AdminContractControl";
            this.Text = "Správa zakázek";
            this.Load += new System.EventHandler(this.AdminContractControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdminContractControl;
        private System.Windows.Forms.ColumnHeader chContractorName;
        private System.Windows.Forms.ColumnHeader chContractDescription;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnAdminContractDelete;
        private System.Windows.Forms.Button btnAdminContractAdd;
        private System.Windows.Forms.Button btnAdminContractEdit;
    }
}