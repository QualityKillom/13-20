using System.ComponentModel;

namespace WinFormsApp1;

partial class frmPCConfiguration
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtComponentId;
        private System.Windows.Forms.TextBox txtConfigurationName;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblComponentId;
        private System.Windows.Forms.Label lblConfigurationName;
        private System.Windows.Forms.Label lblTotalPrice;
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
            this.txtComponentId = new System.Windows.Forms.TextBox();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblComponentId = new System.Windows.Forms.Label();
            this.lblConfigurationName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
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
            // txtComponentId
            // 
            this.txtComponentId.Location = new System.Drawing.Point(150, 100);
            this.txtComponentId.Name = "txtComponentId";
            this.txtComponentId.Size = new System.Drawing.Size(200, 23);
            this.txtComponentId.TabIndex = 1;
            this.txtComponentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtConfigurationName
            // 
            this.txtConfigurationName.Location = new System.Drawing.Point(150, 130);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(200, 23);
            this.txtConfigurationName.TabIndex = 2;
            this.txtConfigurationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(150, 160);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 23);
            this.txtTotalPrice.TabIndex = 3;
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // lblComponentId
            // 
            this.lblComponentId.AutoSize = true;
            this.lblComponentId.Location = new System.Drawing.Point(50, 103);
            this.lblComponentId.Name = "lblComponentId";
            this.lblComponentId.Size = new System.Drawing.Size(94, 13);
            this.lblComponentId.TabIndex = 6;
            this.lblComponentId.Text = "ID компонента:";
            this.lblComponentId.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblConfigurationName
            // 
            this.lblConfigurationName.AutoSize = true;
            this.lblConfigurationName.Location = new System.Drawing.Point(50, 133);
            this.lblConfigurationName.Name = "lblConfigurationName";
            this.lblConfigurationName.Size = new System.Drawing.Size(94, 13);
            this.lblConfigurationName.TabIndex = 7;
            this.lblConfigurationName.Text = "Название конфигурации:";
            this.lblConfigurationName.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(50, 163);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(94, 13);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Общая цена:";
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 50);
            this.panelTop.TabIndex = 9;
            // 
            // frmPCConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblConfigurationName);
            this.Controls.Add(this.lblComponentId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtConfigurationName);
            this.Controls.Add(this.txtComponentId);
            this.Controls.Add(this.txtUserId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPCConfiguration";
            this.Text = "Добавление/Редактирование конфигурации ПК";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }