using System.ComponentModel;

namespace WinFormsApp1;

partial class frmWorker
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.TextBox txtRankId;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblRankId;
        private System.Windows.Forms.Label lblHireDate;
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
            this.txtRankId = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblRankId = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
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
            // txtRankId
            // 
            this.txtRankId.Location = new System.Drawing.Point(150, 100);
            this.txtRankId.Name = "txtRankId";
            this.txtRankId.Size = new System.Drawing.Size(200, 23);
            this.txtRankId.TabIndex = 1;
            this.txtRankId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(150, 130);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 23);
            this.dtpHireDate.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
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
            this.lblPersonId.TabIndex = 4;
            this.lblPersonId.Text = "ID человека:";
            this.lblPersonId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblRankId
            // 
            this.lblRankId.AutoSize = true;
            this.lblRankId.Location = new System.Drawing.Point(50, 103);
            this.lblRankId.Name = "lblRankId";
            this.lblRankId.Size = new System.Drawing.Size(94, 13);
            this.lblRankId.TabIndex = 5;
            this.lblRankId.Text = "ID должности:";
            this.lblRankId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(50, 133);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(94, 13);
            this.lblHireDate.TabIndex = 6;
            this.lblHireDate.Text = "Дата найма:";
            this.lblHireDate.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 50);
            this.panelTop.TabIndex = 7;
            // 
            // frmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblRankId);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.txtRankId);
            this.Controls.Add(this.txtPersonId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWorker";
            this.Text = "Добавление/Редактирование сотрудника";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }