using System.ComponentModel;

namespace WinFormsApp1;

partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eduLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialtiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem institutionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eduLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialtiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.institutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.workersToolStripMenuItem,
            this.banksToolStripMenuItem,
            this.cardsToolStripMenuItem,
            this.eduLevelsToolStripMenuItem,
            this.specialtiesToolStripMenuItem,
            this.qualificationsToolStripMenuItem,
            this.institutionsToolStripMenuItem,
            this.educationsToolStripMenuItem,
            this.documentTypesToolStripMenuItem,
            this.organizationsToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.componentsToolStripMenuItem,
            this.configurationsToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Справочники";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peopleToolStripMenuItem.Text = "Люди";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workersToolStripMenuItem.Text = "Сотрудники";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // banksToolStripMenuItem
            // 
            this.banksToolStripMenuItem.Name = "banksToolStripMenuItem";
            this.banksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.banksToolStripMenuItem.Text = "Банки";
            this.banksToolStripMenuItem.Click += new System.EventHandler(this.banksToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cardsToolStripMenuItem.Text = "Карты";
            this.cardsToolStripMenuItem.Click += new System.EventHandler(this.cardsToolStripMenuItem_Click);
            // 
            // eduLevelsToolStripMenuItem
            // 
            this.eduLevelsToolStripMenuItem.Name = "eduLevelsToolStripMenuItem";
            this.eduLevelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eduLevelsToolStripMenuItem.Text = "Уровни образования";
            this.eduLevelsToolStripMenuItem.Click += new System.EventHandler(this.eduLevelsToolStripMenuItem_Click);
            // 
            // specialtiesToolStripMenuItem
            // 
            this.specialtiesToolStripMenuItem.Name = "specialtiesToolStripMenuItem";
            this.specialtiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.specialtiesToolStripMenuItem.Text = "Специальности";
            this.specialtiesToolStripMenuItem.Click += new System.EventHandler(this.specialtiesToolStripMenuItem_Click);
            // 
            // qualificationsToolStripMenuItem
            // 
            this.qualificationsToolStripMenuItem.Name = "qualificationsToolStripMenuItem";
            this.qualificationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qualificationsToolStripMenuItem.Text = "Квалификации";
            this.qualificationsToolStripMenuItem.Click += new System.EventHandler(this.qualificationsToolStripMenuItem_Click);
            // 
            // institutionsToolStripMenuItem
            // 
            this.institutionsToolStripMenuItem.Name = "institutionsToolStripMenuItem";
            this.institutionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.institutionsToolStripMenuItem.Text = "Учебные заведения";
            this.institutionsToolStripMenuItem.Click += new System.EventHandler(this.institutionsToolStripMenuItem_Click);
          
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.componentsToolStripMenuItem.Text = "Компоненты";
            this.componentsToolStripMenuItem.Click += new System.EventHandler(this.componentsToolStripMenuItem_Click);
            // 
            // configurationsToolStripMenuItem
            // 
            this.configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            this.configurationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configurationsToolStripMenuItem.Text = "Конфигурации";
            this.configurationsToolStripMenuItem.Click += new System.EventHandler(this.configurationsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem.Text = "Заказы";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Система управления сотрудниками и ПК";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
