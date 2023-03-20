namespace Projekt
{
    partial class AdminMainForm
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnWorkHours = new System.Windows.Forms.Button();
            this.btnWorkType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsers.Location = new System.Drawing.Point(9, 10);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(118, 31);
            this.btnUsers.TabIndex = 10;
            this.btnUsers.Text = "Správa uživatelů";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRoles.Location = new System.Drawing.Point(173, 10);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(118, 31);
            this.btnRoles.TabIndex = 11;
            this.btnRoles.Text = "Správa rolí";
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnContracts.Location = new System.Drawing.Point(173, 54);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(118, 31);
            this.btnContracts.TabIndex = 13;
            this.btnContracts.Text = "Správa kontraktů";
            this.btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEmployees.Location = new System.Drawing.Point(9, 49);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(118, 43);
            this.btnEmployees.TabIndex = 12;
            this.btnEmployees.Text = "Správa zaměstnanců";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnWorkHours
            // 
            this.btnWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkHours.Location = new System.Drawing.Point(173, 93);
            this.btnWorkHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWorkHours.Name = "btnWorkHours";
            this.btnWorkHours.Size = new System.Drawing.Size(118, 46);
            this.btnWorkHours.TabIndex = 15;
            this.btnWorkHours.Text = "Odpracované hodiny";
            this.btnWorkHours.UseVisualStyleBackColor = true;
            // 
            // btnWorkType
            // 
            this.btnWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkType.Location = new System.Drawing.Point(9, 101);
            this.btnWorkType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWorkType.Name = "btnWorkType";
            this.btnWorkType.Size = new System.Drawing.Size(118, 31);
            this.btnWorkType.TabIndex = 14;
            this.btnWorkType.Text = "Správa prací";
            this.btnWorkType.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 155);
            this.Controls.Add(this.btnWorkHours);
            this.Controls.Add(this.btnWorkType);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnUsers);
            this.MinimumSize = new System.Drawing.Size(294, 193);
            this.Name = "MainForm";
            this.Text = "Main menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnWorkHours;
        private System.Windows.Forms.Button btnWorkType;
    }
}

