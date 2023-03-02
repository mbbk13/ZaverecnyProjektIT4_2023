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
            this.SuspendLayout();
            // 
            // lvAdminUsersControl
            // 
            this.lvAdminUsersControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeName,
            this.chUserName});
            this.lvAdminUsersControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdminUsersControl.FullRowSelect = true;
            this.lvAdminUsersControl.GridLines = true;
            this.lvAdminUsersControl.HideSelection = false;
            this.lvAdminUsersControl.Location = new System.Drawing.Point(0, 0);
            this.lvAdminUsersControl.Name = "lvAdminUsersControl";
            this.lvAdminUsersControl.Size = new System.Drawing.Size(288, 450);
            this.lvAdminUsersControl.TabIndex = 0;
            this.lvAdminUsersControl.UseCompatibleStateImageBehavior = false;
            this.lvAdminUsersControl.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeName
            // 
            this.chEmployeeName.Text = "Jméno zaměstnance";
            this.chEmployeeName.Width = 142;
            // 
            // chUserName
            // 
            this.chUserName.Text = "Uživatelské jméno";
            this.chUserName.Width = 142;
            // 
            // AdminUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAdminUsersControl);
            this.Name = "AdminUsersControl";
            this.Text = "Správa uživatelů";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdminUsersControl;
        private System.Windows.Forms.ColumnHeader chEmployeeName;
        private System.Windows.Forms.ColumnHeader chUserName;
    }
}