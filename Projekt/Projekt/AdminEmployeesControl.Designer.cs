namespace Projekt
{
    partial class AdminEmployeesControl
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
            this.btnAdminUserDelete = new System.Windows.Forms.Button();
            this.btnAdminUserAdd = new System.Windows.Forms.Button();
            this.btnAdminEmployeeEdit = new System.Windows.Forms.Button();
            this.lvAdminEmployeesControl = new System.Windows.Forms.ListView();
            this.chEmployeeFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeeLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeeBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeeEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmployeePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdminUserDelete
            // 
            this.btnAdminUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserDelete.Image = global::Projekt.Properties.Resources.remove_user;
            this.btnAdminUserDelete.Location = new System.Drawing.Point(892, 87);
            this.btnAdminUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserDelete.Name = "btnAdminUserDelete";
            this.btnAdminUserDelete.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserDelete.TabIndex = 7;
            this.btnAdminUserDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserDelete.UseVisualStyleBackColor = true;
            this.btnAdminUserDelete.Click += new System.EventHandler(this.btnAdminUserDelete_Click);
            // 
            // btnAdminUserAdd
            // 
            this.btnAdminUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserAdd.Image = global::Projekt.Properties.Resources.add_user;
            this.btnAdminUserAdd.Location = new System.Drawing.Point(892, 49);
            this.btnAdminUserAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserAdd.Name = "btnAdminUserAdd";
            this.btnAdminUserAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserAdd.TabIndex = 6;
            this.btnAdminUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserAdd.UseVisualStyleBackColor = true;
            this.btnAdminUserAdd.Click += new System.EventHandler(this.btnAdminUserAdd_Click);
            // 
            // btnAdminEmployeeEdit
            // 
            this.btnAdminEmployeeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminEmployeeEdit.Image = global::Projekt.Properties.Resources.user_edit1;
            this.btnAdminEmployeeEdit.Location = new System.Drawing.Point(892, 11);
            this.btnAdminEmployeeEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminEmployeeEdit.Name = "btnAdminEmployeeEdit";
            this.btnAdminEmployeeEdit.Size = new System.Drawing.Size(75, 34);
            this.btnAdminEmployeeEdit.TabIndex = 5;
            this.btnAdminEmployeeEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminEmployeeEdit.UseVisualStyleBackColor = true;
            this.btnAdminEmployeeEdit.Click += new System.EventHandler(this.btnAdminEmployeeEdit_Click);
            // 
            // lvAdminEmployeesControl
            // 
            this.lvAdminEmployeesControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeFirstName,
            this.chEmployeeLastName,
            this.chId,
            this.chEmployeeBirthDate,
            this.chEmployeeEmail,
            this.chEmployeePhone});
            this.lvAdminEmployeesControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdminEmployeesControl.FullRowSelect = true;
            this.lvAdminEmployeesControl.GridLines = true;
            this.lvAdminEmployeesControl.HideSelection = false;
            this.lvAdminEmployeesControl.Location = new System.Drawing.Point(0, 0);
            this.lvAdminEmployeesControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdminEmployeesControl.Name = "lvAdminEmployeesControl";
            this.lvAdminEmployeesControl.Size = new System.Drawing.Size(863, 185);
            this.lvAdminEmployeesControl.TabIndex = 4;
            this.lvAdminEmployeesControl.UseCompatibleStateImageBehavior = false;
            this.lvAdminEmployeesControl.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeFirstName
            // 
            this.chEmployeeFirstName.DisplayIndex = 1;
            this.chEmployeeFirstName.Text = "Jméno zaměstnance";
            this.chEmployeeFirstName.Width = 120;
            // 
            // chEmployeeLastName
            // 
            this.chEmployeeLastName.DisplayIndex = 2;
            this.chEmployeeLastName.Text = "Příjmení zaměstnance";
            this.chEmployeeLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeeLastName.Width = 140;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Identifikační č.";
            this.chId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chId.Width = 95;
            // 
            // chEmployeeBirthDate
            // 
            this.chEmployeeBirthDate.Text = "Datum narození";
            this.chEmployeeBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeeBirthDate.Width = 110;
            // 
            // chEmployeeEmail
            // 
            this.chEmployeeEmail.Text = "E-mail";
            this.chEmployeeEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeeEmail.Width = 100;
            // 
            // chEmployeePhone
            // 
            this.chEmployeePhone.Text = "Tel. číslo";
            this.chEmployeePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeePhone.Width = 100;
            // 
            // AdminEmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 185);
            this.Controls.Add(this.btnAdminUserDelete);
            this.Controls.Add(this.btnAdminUserAdd);
            this.Controls.Add(this.btnAdminEmployeeEdit);
            this.Controls.Add(this.lvAdminEmployeesControl);
            this.MinimumSize = new System.Drawing.Size(980, 232);
            this.Name = "AdminEmployeesControl";
            this.Text = "Správa zaměstnanců";
            this.Load += new System.EventHandler(this.AdminEmployeesControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminUserDelete;
        private System.Windows.Forms.Button btnAdminUserAdd;
        private System.Windows.Forms.Button btnAdminEmployeeEdit;
        private System.Windows.Forms.ListView lvAdminEmployeesControl;
        private System.Windows.Forms.ColumnHeader chEmployeeFirstName;
        private System.Windows.Forms.ColumnHeader chEmployeeLastName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chEmployeeBirthDate;
        private System.Windows.Forms.ColumnHeader chEmployeeEmail;
        private System.Windows.Forms.ColumnHeader chEmployeePhone;
    }
}