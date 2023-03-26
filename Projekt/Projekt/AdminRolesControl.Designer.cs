namespace Projekt
{
    partial class AdminRolesControl
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
            this.lvAdminRolesControl = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdminRoleDelete = new System.Windows.Forms.Button();
            this.btnAdminRoleAdd = new System.Windows.Forms.Button();
            this.btnAdminRoleEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAdminRolesControl
            // 
            this.lvAdminRolesControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId});
            this.lvAdminRolesControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdminRolesControl.FullRowSelect = true;
            this.lvAdminRolesControl.GridLines = true;
            this.lvAdminRolesControl.HideSelection = false;
            this.lvAdminRolesControl.Location = new System.Drawing.Point(0, 0);
            this.lvAdminRolesControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdminRolesControl.Name = "lvAdminRolesControl";
            this.lvAdminRolesControl.Size = new System.Drawing.Size(131, 290);
            this.lvAdminRolesControl.TabIndex = 0;
            this.lvAdminRolesControl.UseCompatibleStateImageBehavior = false;
            this.lvAdminRolesControl.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.DisplayIndex = 1;
            this.chName.Text = "Název";
            this.chName.Width = 100;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Id";
            this.chId.Width = 40;
            // 
            // btnAdminRoleDelete
            // 
            this.btnAdminRoleDelete.Image = global::Projekt.Properties.Resources.bin;
            this.btnAdminRoleDelete.Location = new System.Drawing.Point(162, 95);
            this.btnAdminRoleDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminRoleDelete.Name = "btnAdminRoleDelete";
            this.btnAdminRoleDelete.Size = new System.Drawing.Size(75, 36);
            this.btnAdminRoleDelete.TabIndex = 3;
            this.btnAdminRoleDelete.UseVisualStyleBackColor = true;
            this.btnAdminRoleDelete.Click += new System.EventHandler(this.btnAdminRoleDelete_Click);
            // 
            // btnAdminRoleAdd
            // 
            this.btnAdminRoleAdd.Image = global::Projekt.Properties.Resources.add;
            this.btnAdminRoleAdd.Location = new System.Drawing.Point(162, 53);
            this.btnAdminRoleAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminRoleAdd.Name = "btnAdminRoleAdd";
            this.btnAdminRoleAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdminRoleAdd.TabIndex = 2;
            this.btnAdminRoleAdd.UseVisualStyleBackColor = true;
            this.btnAdminRoleAdd.Click += new System.EventHandler(this.btnAdminRoleAdd_Click);
            // 
            // btnAdminRoleEdit
            // 
            this.btnAdminRoleEdit.Image = global::Projekt.Properties.Resources.pencil;
            this.btnAdminRoleEdit.Location = new System.Drawing.Point(162, 11);
            this.btnAdminRoleEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminRoleEdit.Name = "btnAdminRoleEdit";
            this.btnAdminRoleEdit.Size = new System.Drawing.Size(75, 36);
            this.btnAdminRoleEdit.TabIndex = 1;
            this.btnAdminRoleEdit.UseVisualStyleBackColor = true;
            this.btnAdminRoleEdit.Click += new System.EventHandler(this.btnAdminRoleEdit_Click);
            // 
            // AdminRolesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 290);
            this.Controls.Add(this.btnAdminRoleDelete);
            this.Controls.Add(this.btnAdminRoleAdd);
            this.Controls.Add(this.btnAdminRoleEdit);
            this.Controls.Add(this.lvAdminRolesControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(258, 328);
            this.Name = "AdminRolesControl";
            this.Text = "Správa rolí";
            this.Load += new System.EventHandler(this.AdminRolesControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdminRolesControl;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnAdminRoleEdit;
        private System.Windows.Forms.Button btnAdminRoleAdd;
        private System.Windows.Forms.Button btnAdminRoleDelete;
        private System.Windows.Forms.ColumnHeader chId;
    }
}