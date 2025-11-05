using System.ComponentModel;

namespace WinFormsApp1;

partial class frmOrder
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtConfigurationId;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblConfigurationId;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblStatus;
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
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtConfigurationId = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblConfigurationId = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(150, 70);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 23);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtConfigurationId
            // 
            this.txtConfigurationId.Location = new System.Drawing.Point(150, 100);
            this.txtConfigurationId.Name = "txtConfigurationId";
            this.txtConfigurationId.Size = new System.Drawing.Size(200, 23);
            this.txtConfigurationId.TabIndex = 1;
            this.txtConfigurationId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(150, 130);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 23);
            this.dtpOrderDate.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(150, 160);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            this.txtStatus.TabIndex = 3;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(50, 73);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(94, 13);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.Text = "ID пользователя:";
            this.lblUserId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblConfigurationId
            // 
            this.lblConfigurationId.AutoSize = true;
            this.lblConfigurationId.Location = new System.Drawing.Point(50, 103);
            this.lblConfigurationId.Name = "lblConfigurationId";
            this.lblConfigurationId.Size = new System.Drawing.Size(94, 13);
            this.lblConfigurationId.TabIndex = 6;
            this.lblConfigurationId.Text = "ID конфигурации:";
            this.lblConfigurationId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(50, 133);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(94, 13);
            this.lblOrderDate.TabIndex = 7;
            this.lblOrderDate.Text = "Дата заказа:";
            this.lblOrderDate.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 163);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Статус:";
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 50);
            this.panelTop.TabIndex = 9;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblConfigurationId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtConfigurationId);
            this.Controls.Add(this.txtUserId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrder";
            this.Text = "Добавление/Редактирование заказа";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }