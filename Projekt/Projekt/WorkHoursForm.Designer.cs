namespace Projekt
{
    partial class WorkHoursForm
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
            this.lvWorkHours = new System.Windows.Forms.ListView();
            this.chEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContractName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdminUserDelete
            // 
            this.btnAdminUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserDelete.Image = global::Projekt.Properties.Resources.bin;
            this.btnAdminUserDelete.Location = new System.Drawing.Point(519, 75);
            this.btnAdminUserDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminUserDelete.Name = "btnAdminUserDelete";
            this.btnAdminUserDelete.Size = new System.Drawing.Size(56, 28);
            this.btnAdminUserDelete.TabIndex = 7;
            this.btnAdminUserDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdminUserAdd
            // 
            this.btnAdminUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserAdd.Image = global::Projekt.Properties.Resources.add;
            this.btnAdminUserAdd.Location = new System.Drawing.Point(519, 43);
            this.btnAdminUserAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminUserAdd.Name = "btnAdminUserAdd";
            this.btnAdminUserAdd.Size = new System.Drawing.Size(56, 28);
            this.btnAdminUserAdd.TabIndex = 6;
            this.btnAdminUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdminUserEdit
            // 
            this.btnAdminUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminUserEdit.Image = global::Projekt.Properties.Resources.pencil;
            this.btnAdminUserEdit.Location = new System.Drawing.Point(519, 11);
            this.btnAdminUserEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminUserEdit.Name = "btnAdminUserEdit";
            this.btnAdminUserEdit.Size = new System.Drawing.Size(56, 28);
            this.btnAdminUserEdit.TabIndex = 5;
            this.btnAdminUserEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUserEdit.UseVisualStyleBackColor = true;
            // 
            // lvWorkHours
            // 
            this.lvWorkHours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeName,
            this.chContractName,
            this.chId,
            this.chWorkType,
            this.chHours});
            this.lvWorkHours.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvWorkHours.FullRowSelect = true;
            this.lvWorkHours.GridLines = true;
            this.lvWorkHours.HideSelection = false;
            this.lvWorkHours.Location = new System.Drawing.Point(0, 0);
            this.lvWorkHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvWorkHours.Name = "lvWorkHours";
            this.lvWorkHours.Size = new System.Drawing.Size(498, 366);
            this.lvWorkHours.TabIndex = 4;
            this.lvWorkHours.UseCompatibleStateImageBehavior = false;
            this.lvWorkHours.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeName
            // 
            this.chEmployeeName.DisplayIndex = 2;
            this.chEmployeeName.Text = "Jméno zaměstnance";
            this.chEmployeeName.Width = 110;
            // 
            // chContractName
            // 
            this.chContractName.DisplayIndex = 3;
            this.chContractName.Text = "Název zakázky";
            this.chContractName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chContractName.Width = 100;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "č.";
            this.chId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chId.Width = 25;
            // 
            // chWorkType
            // 
            this.chWorkType.DisplayIndex = 4;
            this.chWorkType.Text = "Typ odvedené práce";
            this.chWorkType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWorkType.Width = 111;
            // 
            // chHours
            // 
            this.chHours.DisplayIndex = 1;
            this.chHours.Text = "Odpracované hodiny";
            this.chHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHours.Width = 120;
            // 
            // WorkHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 366);
            this.Controls.Add(this.btnAdminUserDelete);
            this.Controls.Add(this.btnAdminUserAdd);
            this.Controls.Add(this.btnAdminUserEdit);
            this.Controls.Add(this.lvWorkHours);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkHoursForm";
            this.Text = "Kontrola odpracovaných hodin";
            this.Load += new System.EventHandler(this.WorkHoursForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminUserDelete;
        private System.Windows.Forms.Button btnAdminUserAdd;
        private System.Windows.Forms.Button btnAdminUserEdit;
        private System.Windows.Forms.ListView lvWorkHours;
        private System.Windows.Forms.ColumnHeader chEmployeeName;
        private System.Windows.Forms.ColumnHeader chContractName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chWorkType;
        private System.Windows.Forms.ColumnHeader chHours;
    }
}