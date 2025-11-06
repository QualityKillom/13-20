namespace WinFormsApp1
{
    partial class frmEducation
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbWorkerId;
        private System.Windows.Forms.ComboBox cmbEduLevelId;
        private System.Windows.Forms.ComboBox cmbSpecialtyId;
        private System.Windows.Forms.ComboBox cmbQualificationId;
        private System.Windows.Forms.ComboBox cmbInstitutionId;
        private System.Windows.Forms.TextBox txtGraduationYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWorkerId;
        private System.Windows.Forms.Label lblEduLevelId;
        private System.Windows.Forms.Label lblSpecialtyId;
        private System.Windows.Forms.Label lblQualificationId;
        private System.Windows.Forms.Label lblInstitutionId;
        private System.Windows.Forms.Label lblGraduationYear;
        private System.Windows.Forms.Panel panelTop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbWorkerId = new System.Windows.Forms.ComboBox();
            this.cmbEduLevelId = new System.Windows.Forms.ComboBox();
            this.cmbSpecialtyId = new System.Windows.Forms.ComboBox();
            this.cmbQualificationId = new System.Windows.Forms.ComboBox();
            this.cmbInstitutionId = new System.Windows.Forms.ComboBox();
            this.txtGraduationYear = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWorkerId = new System.Windows.Forms.Label();
            this.lblEduLevelId = new System.Windows.Forms.Label();
            this.lblSpecialtyId = new System.Windows.Forms.Label();
            this.lblQualificationId = new System.Windows.Forms.Label();
            this.lblInstitutionId = new System.Windows.Forms.Label();
            this.lblGraduationYear = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmbWorkerId
            // 
            this.cmbWorkerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkerId.FormattingEnabled = true;
            this.cmbWorkerId.Location = new System.Drawing.Point(150, 70);
            this.cmbWorkerId.Name = "cmbWorkerId";
            this.cmbWorkerId.Size = new System.Drawing.Size(200, 21);
            this.cmbWorkerId.TabIndex = 0;
            // 
            // cmbEduLevelId
            // 
            this.cmbEduLevelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEduLevelId.FormattingEnabled = true;
            this.cmbEduLevelId.Location = new System.Drawing.Point(150, 100);
            this.cmbEduLevelId.Name = "cmbEduLevelId";
            this.cmbEduLevelId.Size = new System.Drawing.Size(200, 21);
            this.cmbEduLevelId.TabIndex = 1;
            // 
            // cmbSpecialtyId
            // 
            this.cmbSpecialtyId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialtyId.FormattingEnabled = true;
            this.cmbSpecialtyId.Location = new System.Drawing.Point(150, 130);
            this.cmbSpecialtyId.Name = "cmbSpecialtyId";
            this.cmbSpecialtyId.Size = new System.Drawing.Size(200, 21);
            this.cmbSpecialtyId.TabIndex = 2;
            // 
            // cmbQualificationId
            // 
            this.cmbQualificationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualificationId.FormattingEnabled = true;
            this.cmbQualificationId.Location = new System.Drawing.Point(150, 160);
            this.cmbQualificationId.Name = "cmbQualificationId";
            this.cmbQualificationId.Size = new System.Drawing.Size(200, 21);
            this.cmbQualificationId.TabIndex = 3;
            // 
            // cmbInstitutionId
            // 
            this.cmbInstitutionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitutionId.FormattingEnabled = true;
            this.cmbInstitutionId.Location = new System.Drawing.Point(150, 190);
            this.cmbInstitutionId.Name = "cmbInstitutionId";
            this.cmbInstitutionId.Size = new System.Drawing.Size(200, 21);
            this.cmbInstitutionId.TabIndex = 4;
            // 
            // txtGraduationYear
            // 
            this.txtGraduationYear.Location = new System.Drawing.Point(150, 220);
            this.txtGraduationYear.Name = "txtGraduationYear";
            this.txtGraduationYear.Size = new System.Drawing.Size(200, 23);
            this.txtGraduationYear.TabIndex = 5;
            this.txtGraduationYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); // Яркий синий
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWorkerId
            // 
            this.lblWorkerId.AutoSize = true;
            this.lblWorkerId.Location = new System.Drawing.Point(50, 73);
            this.lblWorkerId.Name = "lblWorkerId";
            this.lblWorkerId.Size = new System.Drawing.Size(94, 13);
            this.lblWorkerId.TabIndex = 7;
            this.lblWorkerId.Text = "ID работника:";
            this.lblWorkerId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); // Темно-синий текст
            // 
            // lblEduLevelId
            // 
            this.lblEduLevelId.AutoSize = true;
            this.lblEduLevelId.Location = new System.Drawing.Point(50, 103);
            this.lblEduLevelId.Name = "lblEduLevelId";
            this.lblEduLevelId.Size = new System.Drawing.Size(94, 13);
            this.lblEduLevelId.TabIndex = 8;
            this.lblEduLevelId.Text = "ID уровня образования:";
            this.lblEduLevelId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblSpecialtyId
            // 
            this.lblSpecialtyId.AutoSize = true;
            this.lblSpecialtyId.Location = new System.Drawing.Point(50, 133);
            this.lblSpecialtyId.Name = "lblSpecialtyId";
            this.lblSpecialtyId.Size = new System.Drawing.Size(94, 13);
            this.lblSpecialtyId.TabIndex = 9;
            this.lblSpecialtyId.Text = "ID специальности:";
            this.lblSpecialtyId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblQualificationId
            // 
            this.lblQualificationId.AutoSize = true;
            this.lblQualificationId.Location = new System.Drawing.Point(50, 163);
            this.lblQualificationId.Name = "lblQualificationId";
            this.lblQualificationId.Size = new System.Drawing.Size(94, 13);
            this.lblQualificationId.TabIndex = 10;
            this.lblQualificationId.Text = "ID квалификации:";
            this.lblQualificationId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblInstitutionId
            // 
            this.lblInstitutionId.AutoSize = true;
            this.lblInstitutionId.Location = new System.Drawing.Point(50, 193);
            this.lblInstitutionId.Name = "lblInstitutionId";
            this.lblInstitutionId.Size = new System.Drawing.Size(94, 13);
            this.lblInstitutionId.TabIndex = 11;
            this.lblInstitutionId.Text = "ID учреждения:";
            this.lblInstitutionId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblGraduationYear
            // 
            this.lblGraduationYear.AutoSize = true;
            this.lblGraduationYear.Location = new System.Drawing.Point(50, 223);
            this.lblGraduationYear.Name = "lblGraduationYear";
            this.lblGraduationYear.Size = new System.Drawing.Size(94, 13);
            this.lblGraduationYear.TabIndex = 12;
            this.lblGraduationYear.Text = "Год выпуска:";
            this.lblGraduationYear.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(51, 153, 255); // Темно-синий верхний бар
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 50);
            this.panelTop.TabIndex = 13;
            // 
            // frmEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblGraduationYear);
            this.Controls.Add(this.lblInstitutionId);
            this.Controls.Add(this.lblQualificationId);
            this.Controls.Add(this.lblSpecialtyId);
            this.Controls.Add(this.lblEduLevelId);
            this.Controls.Add(this.lblWorkerId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGraduationYear);
            this.Controls.Add(this.cmbInstitutionId);
            this.Controls.Add(this.cmbQualificationId);
            this.Controls.Add(this.cmbSpecialtyId);
            this.Controls.Add(this.cmbEduLevelId);
            this.Controls.Add(this.cmbWorkerId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEducation";
            this.Text = "Добавление/Редактирование образования";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}