namespace Projekt
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersButton = new System.Windows.Forms.Button();
            this.RolesButton = new System.Windows.Forms.Button();
            this.ContractsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.WorkHoursButton = new System.Windows.Forms.Button();
            this.WorkTypesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(12, 12);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(84, 38);
            this.UsersButton.TabIndex = 0;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            // 
            // RolesButton
            // 
            this.RolesButton.Location = new System.Drawing.Point(119, 12);
            this.RolesButton.Name = "RolesButton";
            this.RolesButton.Size = new System.Drawing.Size(84, 38);
            this.RolesButton.TabIndex = 1;
            this.RolesButton.Text = "Roles";
            this.RolesButton.UseVisualStyleBackColor = true;
            // 
            // ContractsButton
            // 
            this.ContractsButton.Location = new System.Drawing.Point(119, 74);
            this.ContractsButton.Name = "ContractsButton";
            this.ContractsButton.Size = new System.Drawing.Size(84, 38);
            this.ContractsButton.TabIndex = 3;
            this.ContractsButton.Text = "Contracts";
            this.ContractsButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(12, 74);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(84, 38);
            this.EmployeesButton.TabIndex = 2;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            // 
            // WorkHoursButton
            // 
            this.WorkHoursButton.Location = new System.Drawing.Point(119, 136);
            this.WorkHoursButton.Name = "WorkHoursButton";
            this.WorkHoursButton.Size = new System.Drawing.Size(84, 38);
            this.WorkHoursButton.TabIndex = 5;
            this.WorkHoursButton.Text = "Work hours";
            this.WorkHoursButton.UseVisualStyleBackColor = true;
            // 
            // WorkTypesButton
            // 
            this.WorkTypesButton.Location = new System.Drawing.Point(12, 136);
            this.WorkTypesButton.Name = "WorkTypesButton";
            this.WorkTypesButton.Size = new System.Drawing.Size(84, 38);
            this.WorkTypesButton.TabIndex = 4;
            this.WorkTypesButton.Text = "Work types";
            this.WorkTypesButton.UseVisualStyleBackColor = true;
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 187);
            this.Controls.Add(this.WorkHoursButton);
            this.Controls.Add(this.WorkTypesButton);
            this.Controls.Add(this.ContractsButton);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.RolesButton);
            this.Controls.Add(this.UsersButton);
            this.Name = "MainFormAdmin";
            this.Text = "Main menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button RolesButton;
        private System.Windows.Forms.Button ContractsButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button WorkHoursButton;
        private System.Windows.Forms.Button WorkTypesButton;
    }
}

