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
            this.btnAdminUserDelete = new System.Windows.Forms.Button();
            this.btnAdminUserAdd = new System.Windows.Forms.Button();
            this.btnAdminUserEdit = new System.Windows.Forms.Button();
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
            this.lvAdminUsersControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdminUsersControl.Name = "lvAdminUsersControl";
            this.lvAdminUsersControl.Size = new System.Drawing.Size(584, 458);
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
            // btnAdminUserDelete
            // 
            this.btnAdminUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserDelete.Image = global::Projekt.Properties.Resources.remove_user;
            this.btnAdminUserDelete.Location = new System.Drawing.Point(597, 91);
            this.btnAdminUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserDelete.Name = "btnAdminUserDelete";
            this.btnAdminUserDelete.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserDelete.TabIndex = 3;
            this.btnAdminUserDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserDelete.UseVisualStyleBackColor = true;
            this.btnAdminUserDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // btnAdminUserAdd
            // 
            this.btnAdminUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserAdd.Image = global::Projekt.Properties.Resources.add_user;
            this.btnAdminUserAdd.Location = new System.Drawing.Point(597, 53);
            this.btnAdminUserAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserAdd.Name = "btnAdminUserAdd";
            this.btnAdminUserAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserAdd.TabIndex = 2;
            this.btnAdminUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserAdd.UseVisualStyleBackColor = true;
            this.btnAdminUserAdd.Click += new System.EventHandler(this.btnAdminAdd_Click);
            // 
            // btnAdminUserEdit
            // 
            this.btnAdminUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserEdit.Image = global::Projekt.Properties.Resources.user_edit1;
            this.btnAdminUserEdit.Location = new System.Drawing.Point(597, 14);
            this.btnAdminUserEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserEdit.Name = "btnAdminUserEdit";
            this.btnAdminUserEdit.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserEdit.TabIndex = 1;
            this.btnAdminUserEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserEdit.UseVisualStyleBackColor = true;
            this.btnAdminUserEdit.Click += new System.EventHandler(this.btnAdminEdit_Click);
            // 
            // AdminUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 458);
            this.Controls.Add(this.btnAdminUserDelete);
            this.Controls.Add(this.btnAdminUserAdd);
            this.Controls.Add(this.btnAdminUserEdit);
            this.Controls.Add(this.lvAdminUsersControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(702, 495);
            this.Name = "AdminUsersControl";
            this.Text = "Správa uživatelů";
            this.Load += new System.EventHandler(this.AdminUsersControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdminUsersControl;
        private System.Windows.Forms.ColumnHeader chEmployeeName;
        private System.Windows.Forms.ColumnHeader chUserName;
        private System.Windows.Forms.Button btnAdminUserEdit;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chRole;
        private System.Windows.Forms.Button btnAdminUserAdd;
        private System.Windows.Forms.Button btnAdminUserDelete;
    }
}