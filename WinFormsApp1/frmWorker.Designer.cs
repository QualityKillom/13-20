using System.ComponentModel;

namespace WinFormsApp1;

partial class frmWorker
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblHireDate;

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
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPerson
            // 
            this.cmbPerson.Location = new System.Drawing.Point(120, 20);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(200, 21);
            this.cmbPerson.TabIndex = 0;
            // 
            // cmbRank
            // 
            this.cmbRank.Location = new System.Drawing.Point(120, 50);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(200, 21);
            this.cmbRank.TabIndex = 1;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(120, 80);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpHireDate.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(20, 20);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(100, 20);
            this.lblPerson.Text = "Физлицо:";
            // 
            // lblRank
            // 
            this.lblRank.Location = new System.Drawing.Point(20, 50);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(100, 20);
            this.lblRank.Text = "Должность:";
            // 
            // lblHireDate
            // 
            this.lblHireDate.Location = new System.Drawing.Point(20, 80);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(100, 20);
            this.lblHireDate.Text = "Дата приема:";
            // 
            // frmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 160);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.cmbPerson);
            this.Name = "frmWorker";
            this.Text = "Сотрудник";
            this.ResumeLayout(false);
        }
    }