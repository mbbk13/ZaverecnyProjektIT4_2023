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
            this.btnAdminUserEdit = new System.Windows.Forms.Button();
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
            this.btnAdminUserDelete.Location = new System.Drawing.Point(799, 87);
            this.btnAdminUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserDelete.Name = "btnAdminUserDelete";
            this.btnAdminUserDelete.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserDelete.TabIndex = 7;
            this.btnAdminUserDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdminUserAdd
            // 
            this.btnAdminUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserAdd.Image = global::Projekt.Properties.Resources.add_user;
            this.btnAdminUserAdd.Location = new System.Drawing.Point(799, 49);
            this.btnAdminUserAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserAdd.Name = "btnAdminUserAdd";
            this.btnAdminUserAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserAdd.TabIndex = 6;
            this.btnAdminUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdminUserEdit
            // 
            this.btnAdminUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserEdit.Image = global::Projekt.Properties.Resources.user_edit1;
            this.btnAdminUserEdit.Location = new System.Drawing.Point(799, 11);
            this.btnAdminUserEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminUserEdit.Name = "btnAdminUserEdit";
            this.btnAdminUserEdit.Size = new System.Drawing.Size(75, 34);
            this.btnAdminUserEdit.TabIndex = 5;
            this.btnAdminUserEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserEdit.UseVisualStyleBackColor = true;
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
            this.lvAdminEmployeesControl.Size = new System.Drawing.Size(761, 466);
            this.lvAdminEmployeesControl.TabIndex = 4;
            this.lvAdminEmployeesControl.UseCompatibleStateImageBehavior = false;
            this.lvAdminEmployeesControl.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeFirstName
            // 
            this.chEmployeeFirstName.DisplayIndex = 1;
            this.chEmployeeFirstName.Text = "Jméno zaměstnance";
            this.chEmployeeFirstName.Width = 135;
            // 
            // chEmployeeLastName
            // 
            this.chEmployeeLastName.DisplayIndex = 2;
            this.chEmployeeLastName.Text = "Příjmení zaměstnance";
            this.chEmployeeLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmployeeLastName.Width = 145;
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
            this.chEmployeeEmail.Width = 90;
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
            this.ClientSize = new System.Drawing.Size(902, 466);
            this.Controls.Add(this.btnAdminUserDelete);
            this.Controls.Add(this.btnAdminUserAdd);
            this.Controls.Add(this.btnAdminUserEdit);
            this.Controls.Add(this.lvAdminEmployeesControl);
            this.Name = "AdminEmployeesControl";
            this.Text = "Správa zaměstnanců";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminUserDelete;
        private System.Windows.Forms.Button btnAdminUserAdd;
        private System.Windows.Forms.Button btnAdminUserEdit;
        private System.Windows.Forms.ListView lvAdminEmployeesControl;
        private System.Windows.Forms.ColumnHeader chEmployeeFirstName;
        private System.Windows.Forms.ColumnHeader chEmployeeLastName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chEmployeeBirthDate;
        private System.Windows.Forms.ColumnHeader chEmployeeEmail;
        private System.Windows.Forms.ColumnHeader chEmployeePhone;
    }
}