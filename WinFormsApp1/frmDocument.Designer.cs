using System.ComponentModel;

namespace WinFormsApp1;

partial class frmDocument
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.TextBox txtDocumentTypeId;
        private System.Windows.Forms.TextBox txtOrganizationId;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblDocumentTypeId;
        private System.Windows.Forms.Label lblOrganizationId;
        private System.Windows.Forms.Label lblNumber;
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
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.txtDocumentTypeId = new System.Windows.Forms.TextBox();
            this.txtOrganizationId = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblDocumentTypeId = new System.Windows.Forms.Label();
            this.lblOrganizationId = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(150, 70);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(200, 23);
            this.txtPersonId.TabIndex = 0;
            this.txtPersonId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtDocumentTypeId
            // 
            this.txtDocumentTypeId.Location = new System.Drawing.Point(150, 100);
            this.txtDocumentTypeId.Name = "txtDocumentTypeId";
            this.txtDocumentTypeId.Size = new System.Drawing.Size(200, 23);
            this.txtDocumentTypeId.TabIndex = 1;
            this.txtDocumentTypeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtOrganizationId
            // 
            this.txtOrganizationId.Location = new System.Drawing.Point(150, 130);
            this.txtOrganizationId.Name = "txtOrganizationId";
            this.txtOrganizationId.Size = new System.Drawing.Size(200, 23);
            this.txtOrganizationId.TabIndex = 2;
            this.txtOrganizationId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(150, 160);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 23);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(150, 190);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 23);
            this.dtpIssueDate.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(50, 73);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(94, 13);
            this.lblPersonId.TabIndex = 6;
            this.lblPersonId.Text = "ID персоны:";
            this.lblPersonId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblDocumentTypeId
            // 
            this.lblDocumentTypeId.AutoSize = true;
            this.lblDocumentTypeId.Location = new System.Drawing.Point(50, 103);
            this.lblDocumentTypeId.Name = "lblDocumentTypeId";
            this.lblDocumentTypeId.Size = new System.Drawing.Size(94, 13);
            this.lblDocumentTypeId.TabIndex = 7;
            this.lblDocumentTypeId.Text = "ID типа документа:";
            this.lblDocumentTypeId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblOrganizationId
            // 
            this.lblOrganizationId.AutoSize = true;
            this.lblOrganizationId.Location = new System.Drawing.Point(50, 133);
            this.lblOrganizationId.Name = "lblOrganizationId";
            this.lblOrganizationId.Size = new System.Drawing.Size(94, 13);
            this.lblOrganizationId.TabIndex = 8;
            this.lblOrganizationId.Text = "ID организации:";
            this.lblOrganizationId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(50, 163);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(94, 13);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.Text = "Номер:";
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(50, 193);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(94, 13);
            this.lblIssueDate.TabIndex = 10;
            this.lblIssueDate.Text = "Дата выдачи:";
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 50);
            this.panelTop.TabIndex = 11;
            // 
            // frmDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblOrganizationId);
            this.Controls.Add(this.lblDocumentTypeId);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtOrganizationId);
            this.Controls.Add(this.txtDocumentTypeId);
            this.Controls.Add(this.txtPersonId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDocument";
            this.Text = "Добавление/Редактирование документа";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }