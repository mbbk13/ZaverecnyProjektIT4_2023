namespace Projekt
{
    partial class AdminWorkTypeControl
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
            this.btnAdminRoleDelete = new System.Windows.Forms.Button();
            this.btnAdminRoleAdd = new System.Windows.Forms.Button();
            this.btnAdminRoleEdit = new System.Windows.Forms.Button();
            this.lvAdminWorkTypeControl = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdminRoleDelete
            // 
            this.btnAdminRoleDelete.Image = global::Projekt.Properties.Resources.bin;
            this.btnAdminRoleDelete.Location = new System.Drawing.Point(305, 95);
            this.btnAdminRoleDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminRoleDelete.Name = "btnAdminRoleDelete";
            this.btnAdminRoleDelete.Size = new System.Drawing.Size(75, 36);
            this.btnAdminRoleDelete.TabIndex = 7;
            this.btnAdminRoleDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdminRoleAdd
            // 
            this.btnAdminRoleAdd.Image = global::Projekt.Properties.Resources.add;
            this.btnAdminRoleAdd.Location = new System.Drawing.Point(305, 53);
            this.btnAdminRoleAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminRoleAdd.Name = "btnAdminRoleAdd";
            this.btnAdminRoleAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdminRoleAdd.TabIndex = 6;
            this.btnAdminRoleAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdminRoleEdit
            // 
            this.btnAdminRoleEdit.Image = global::Projekt.Properties.Resources.pencil;
            this.btnAdminRoleEdit.Location = new System.Drawing.Point(305, 11);
            this.btnAdminRoleEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminRoleEdit.Name = "btnAdminRoleEdit";
            this.btnAdminRoleEdit.Size = new System.Drawing.Size(75, 36);
            this.btnAdminRoleEdit.TabIndex = 5;
            this.btnAdminRoleEdit.UseVisualStyleBackColor = true;
            this.btnAdminRoleEdit.Click += new System.EventHandler(this.btnAdminRoleEdit_Click);
            // 
            // lvAdminWorkTypeControl
            // 
            this.lvAdminWorkTypeControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId,
            this.chDescription});
            this.lvAdminWorkTypeControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdminWorkTypeControl.FullRowSelect = true;
            this.lvAdminWorkTypeControl.GridLines = true;
            this.lvAdminWorkTypeControl.HideSelection = false;
            this.lvAdminWorkTypeControl.Location = new System.Drawing.Point(0, 0);
            this.lvAdminWorkTypeControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdminWorkTypeControl.Name = "lvAdminWorkTypeControl";
            this.lvAdminWorkTypeControl.Size = new System.Drawing.Size(272, 290);
            this.lvAdminWorkTypeControl.TabIndex = 4;
            this.lvAdminWorkTypeControl.UseCompatibleStateImageBehavior = false;
            this.lvAdminWorkTypeControl.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.DisplayIndex = 1;
            this.chName.Text = "Název";
            this.chName.Width = 105;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Id";
            this.chId.Width = 40;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Popis";
            this.chDescription.Width = 110;
            // 
            // AdminWorkTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 290);
            this.Controls.Add(this.btnAdminRoleDelete);
            this.Controls.Add(this.btnAdminRoleAdd);
            this.Controls.Add(this.btnAdminRoleEdit);
            this.Controls.Add(this.lvAdminWorkTypeControl);
            this.Name = "AdminWorkTypeControl";
            this.Text = "Správa typů práce";
            this.Load += new System.EventHandler(this.AdminWorkTypeControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminRoleDelete;
        private System.Windows.Forms.Button btnAdminRoleAdd;
        private System.Windows.Forms.Button btnAdminRoleEdit;
        private System.Windows.Forms.ListView lvAdminWorkTypeControl;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chDescription;
    }
}