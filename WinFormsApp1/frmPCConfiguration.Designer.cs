using System.ComponentModel;

namespace WinFormsApp1;

partial class frmPCConfiguration
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.TextBox txtConfigurationName;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblComponent;
        private System.Windows.Forms.Label lblConfigurationName;
        private System.Windows.Forms.Label lblTotalPrice;

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
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblComponent = new System.Windows.Forms.Label();
            this.lblConfigurationName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbUser
            // 
            this.cmbUser.Location = new System.Drawing.Point(150, 20);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(200, 21);
            this.cmbUser.TabIndex = 0;
            // 
            // cmbComponent
            // 
            this.cmbComponent.Location = new System.Drawing.Point(150, 50);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(200, 21);
            this.cmbComponent.TabIndex = 1;
            // 
            // txtConfigurationName
            // 
            this.txtConfigurationName.Location = new System.Drawing.Point(150, 80);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(200, 20);
            this.txtConfigurationName.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(150, 110);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 20);
            this.txtTotalPrice.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(50, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 20);
            this.lblUser.Text = "Пользователь:";
            // 
            // lblComponent
            // 
            this.lblComponent.Location = new System.Drawing.Point(50, 50);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(100, 20);
            this.lblComponent.Text = "Компонент:";
            // 
            // lblConfigurationName
            // 
            this.lblConfigurationName.Location = new System.Drawing.Point(50, 80);
            this.lblConfigurationName.Name = "lblConfigurationName";
            this.lblConfigurationName.Size = new System.Drawing.Size(100, 20);
            this.lblConfigurationName.Text = "Название:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(50, 110);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.lblTotalPrice.Text = "Общая цена:";
            // 
            // frmPCConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblConfigurationName);
            this.Controls.Add(this.lblComponent);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtConfigurationName);
            this.Controls.Add(this.cmbComponent);
            this.Controls.Add(this.cmbUser);
            this.Name = "frmPCConfiguration";
            this.Text = "Конфигурация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }