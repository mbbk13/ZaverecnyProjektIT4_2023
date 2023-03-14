namespace Projekt
{
    partial class AdminUsersControl
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
            this.lvAdminUsersControl = new System.Windows.Forms.ListView();
            this.chEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdminAdd = new System.Windows.Forms.Button();
            this.btnAdminEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAdminUsersControl
            // 
            this.lvAdminUsersControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeName,
            this.chUserName,
            this.chId,
            this.chRole});
            this.lvAdminUsersControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdminUsersControl.FullRowSelect = true;
            this.lvAdminUsersControl.GridLines = true;
            this.lvAdminUsersControl.HideSelection = false;
            this.lvAdminUsersControl.Location = new System.Drawing.Point(0, 0);
            this.lvAdminUsersControl.Margin = new System.Windows.Forms.Padding(2);
            this.lvAdminUsersControl.Name = "lvAdminUsersControl";
            this.lvAdminUsersControl.Size = new System.Drawing.Size(439, 372);
            this.lvAdminUsersControl.TabIndex = 0;
            this.lvAdminUsersControl.UseCompatibleStateImageBehavior = false;
            this.lvAdminUsersControl.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeName
            // 
            this.chEmployeeName.DisplayIndex = 1;
            this.chEmployeeName.Text = "Jméno zaměstnance";
            this.chEmployeeName.Width = 142;
            // 
            // chUserName
            // 
            this.chUserName.DisplayIndex = 2;
            this.chUserName.Text = "Uživatelské jméno";
            this.chUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chUserName.Width = 142;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Identifikační č.";
            this.chId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chId.Width = 91;
            // 
            // chRole
            // 
            this.chRole.Text = "Role";
            this.chRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdminAdd
            // 
            this.btnAdminAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminAdd.Image = global::Projekt.Properties.Resources.add_user;
            this.btnAdminAdd.Location = new System.Drawing.Point(448, 43);
            this.btnAdminAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Size = new System.Drawing.Size(56, 28);
            this.btnAdminAdd.TabIndex = 2;
            this.btnAdminAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdminEdit
            // 
            this.btnAdminEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminEdit.Image = global::Projekt.Properties.Resources.user_edit1;
            this.btnAdminEdit.Location = new System.Drawing.Point(448, 11);
            this.btnAdminEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminEdit.Name = "btnAdminEdit";
            this.btnAdminEdit.Size = new System.Drawing.Size(56, 28);
            this.btnAdminEdit.TabIndex = 1;
            this.btnAdminEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminEdit.UseVisualStyleBackColor = true;
            this.btnAdminEdit.Click += new System.EventHandler(this.btnAdminEdit_Click);
            // 
            // AdminUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 372);
            this.Controls.Add(this.btnAdminAdd);
            this.Controls.Add(this.btnAdminEdit);
            this.Controls.Add(this.lvAdminUsersControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(531, 411);
            this.Name = "AdminUsersControl";
            this.Text = "Správa uživatelů";
            this.Load += new System.EventHandler(this.AdminUsersControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdminUsersControl;
        private System.Windows.Forms.ColumnHeader chEmployeeName;
        private System.Windows.Forms.ColumnHeader chUserName;
        private System.Windows.Forms.Button btnAdminEdit;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chRole;
        private System.Windows.Forms.Button btnAdminAdd;
    }
}