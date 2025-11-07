namespace WinFormsApp1
{
    partial class frmEducation
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Label lblEduLevel;
        private System.Windows.Forms.ComboBox cmbEduLevel;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.ComboBox cmbQualification;
        private System.Windows.Forms.Label lblInstitution;
        private System.Windows.Forms.ComboBox cmbInstitution;
        private System.Windows.Forms.Label lblGraduationYear;
        private System.Windows.Forms.NumericUpDown nudGraduationYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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
            this.lblWorker = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.lblEduLevel = new System.Windows.Forms.Label();
            this.cmbEduLevel = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.cmbQualification = new System.Windows.Forms.ComboBox();
            this.lblInstitution = new System.Windows.Forms.Label();
            this.cmbInstitution = new System.Windows.Forms.ComboBox();
            this.lblGraduationYear = new System.Windows.Forms.Label();
            this.nudGraduationYear = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGraduationYear)).BeginInit();
            this.SuspendLayout();

            // lblWorker
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(12, 15);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(45, 13);
            this.lblWorker.Text = "Worker:";

            // cmbWorker
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(80, 12);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(200, 21);
            this.cmbWorker.TabIndex = 0;

            // lblEduLevel
            this.lblEduLevel.AutoSize = true;
            this.lblEduLevel.Location = new System.Drawing.Point(12, 45);
            this.lblEduLevel.Name = "lblEduLevel";
            this.lblEduLevel.Size = new System.Drawing.Size(62, 13);
            this.lblEduLevel.Text = "Edu Level:";

            // cmbEduLevel
            this.cmbEduLevel.FormattingEnabled = true;
            this.cmbEduLevel.Location = new System.Drawing.Point(80, 42);
            this.cmbEduLevel.Name = "cmbEduLevel";
            this.cmbEduLevel.Size = new System.Drawing.Size(200, 21);
            this.cmbEduLevel.TabIndex = 1;

            // lblSpecialty
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(12, 75);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(53, 13);
            this.lblSpecialty.Text = "Specialty:";

            // cmbSpecialty
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.Location = new System.Drawing.Point(80, 72);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(200, 21);
            this.cmbSpecialty.TabIndex = 2;

            // lblQualification
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(12, 105);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(68, 13);
            this.lblQualification.Text = "Qualification:";

            // cmbQualification
            this.cmbQualification.FormattingEnabled = true;
            this.cmbQualification.Location = new System.Drawing.Point(80, 102);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size = new System.Drawing.Size(200, 21);
            this.cmbQualification.TabIndex = 3;

            // lblInstitution
            this.lblInstitution.AutoSize = true;
            this.lblInstitution.Location = new System.Drawing.Point(12, 135);
            this.lblInstitution.Name = "lblInstitution";
            this.lblInstitution.Size = new System.Drawing.Size(59, 13);
            this.lblInstitution.Text = "Institution:";

            // cmbInstitution
            this.cmbInstitution.FormattingEnabled = true;
            this.cmbInstitution.Location = new System.Drawing.Point(80, 132);
            this.cmbInstitution.Name = "cmbInstitution";
            this.cmbInstitution.Size = new System.Drawing.Size(200, 21);
            this.cmbInstitution.TabIndex = 4;

            // lblGraduationYear
            this.lblGraduationYear.AutoSize = true;
            this.lblGraduationYear.Location = new System.Drawing.Point(12, 165);
            this.lblGraduationYear.Name = "lblGraduationYear";
            this.lblGraduationYear.Size = new System.Drawing.Size(80, 13);
            this.lblGraduationYear.Text = "Graduation Year:";

            // nudGraduationYear
            this.nudGraduationYear.Location = new System.Drawing.Point(80, 162);
            this.nudGraduationYear.Maximum = 2100;
            this.nudGraduationYear.Minimum = 1900;
            this.nudGraduationYear.Name = "nudGraduationYear";
            this.nudGraduationYear.Size = new System.Drawing.Size(200, 20);
            this.nudGraduationYear.TabIndex = 5;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(124, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(205, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // frmEducation
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 235);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudGraduationYear);
            this.Controls.Add(this.lblGraduationYear);
            this.Controls.Add(this.cmbInstitution);
            this.Controls.Add(this.lblInstitution);
            this.Controls.Add(this.cmbQualification);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.cmbSpecialty);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.cmbEduLevel);
            this.Controls.Add(this.lblEduLevel);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.lblWorker);
            this.Name = "frmEducation";
            this.Text = "Education";
            ((System.ComponentModel.ISupportInitialize)(this.nudGraduationYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}