using System.ComponentModel;

namespace WinFormsApp1;

partial class frmCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtWorkerId;
        private System.Windows.Forms.TextBox txtBankId;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWorkerId;
        private System.Windows.Forms.Label lblBankId;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblIssueDate;
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
            this.txtWorkerId = new System.Windows.Forms.TextBox();
            this.txtBankId = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWorkerId = new System.Windows.Forms.Label();
            this.lblBankId = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.Location = new System.Drawing.Point(150, 70);
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.Size = new System.Drawing.Size(200, 23);
            this.txtWorkerId.TabIndex = 0;
            this.txtWorkerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtBankId
            // 
            this.txtBankId.Location = new System.Drawing.Point(150, 100);
            this.txtBankId.Name = "txtBankId";
            this.txtBankId.Size = new System.Drawing.Size(200, 23);
            this.txtBankId.TabIndex = 1;
            this.txtBankId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(150, 130);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(200, 23);
            this.txtCardNumber.TabIndex = 2;
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(150, 160);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 23);
            this.dtpIssueDate.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
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
            this.lblWorkerId.TabIndex = 5;
            this.lblWorkerId.Text = "ID сотрудника:";
            this.lblWorkerId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblBankId
            // 
            this.lblBankId.AutoSize = true;
            this.lblBankId.Location = new System.Drawing.Point(50, 103);
            this.lblBankId.Name = "lblBankId";
            this.lblBankId.Size = new System.Drawing.Size(94, 13);
            this.lblBankId.TabIndex = 6;
            this.lblBankId.Text = "ID банка:";
            this.lblBankId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(50, 133);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(94, 13);
            this.lblCardNumber.TabIndex = 7;
            this.lblCardNumber.Text = "Номер карты:";
            this.lblCardNumber.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(50, 163);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(94, 13);
            this.lblIssueDate.TabIndex = 8;
            this.lblIssueDate.Text = "Дата выдачи:";
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 50);
            this.panelTop.TabIndex = 9;
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblBankId);
            this.Controls.Add(this.lblWorkerId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtBankId);
            this.Controls.Add(this.txtWorkerId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCard";
            this.Text = "Добавление/Редактирование карты";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }