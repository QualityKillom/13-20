namespace WinFormsApp1
{
    partial class frmWorker
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
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
            this.lblPerson = new System.Windows.Forms.Label();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblPerson
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(12, 15);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(45, 13);
            this.lblPerson.Text = "Person:";

            // cmbPerson
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(80, 12);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(200, 21);
            this.cmbPerson.TabIndex = 0;

            // lblRank
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(12, 45);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(35, 13);
            this.lblRank.Text = "Rank:";

            // cmbRank
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(80, 42);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(200, 21);
            this.cmbRank.TabIndex = 1;

            // lblHireDate
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(12, 75);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(54, 13);
            this.lblHireDate.Text = "Hire Date:";

            // dtpHireDate
            this.dtpHireDate.Location = new System.Drawing.Point(80, 72);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpHireDate.TabIndex = 2;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(124, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(205, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // frmWorker
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 145);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.lblPerson);
            this.Name = "frmWorker";
            this.Text = "Worker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}