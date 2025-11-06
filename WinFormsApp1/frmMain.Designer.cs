namespace WinFormsApp1
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eduLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialtiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem institutionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        // Добавленные пункты меню
        private System.Windows.Forms.ToolStripMenuItem ranksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;

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
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eduLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialtiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.institutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // Добавленные пункты меню
            this.ranksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.workersToolStripMenuItem,
            this.banksToolStripMenuItem,
            this.cardsToolStripMenuItem,
            this.eduLevelsToolStripMenuItem,
            this.specialtiesToolStripMenuItem,
            this.qualificationsToolStripMenuItem,
            this.institutionsToolStripMenuItem,
            this.componentsToolStripMenuItem,
            this.configurationsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.ranksToolStripMenuItem,
            this.educationToolStripMenuItem,
            this.documentTypesToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.organizationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.workersToolStripMenuItem.Text = "Workers";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // banksToolStripMenuItem
            // 
            this.banksToolStripMenuItem.Name = "banksToolStripMenuItem";
            this.banksToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.banksToolStripMenuItem.Text = "Banks";
            this.banksToolStripMenuItem.Click += new System.EventHandler(this.banksToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.cardsToolStripMenuItem.Text = "Cards";
            this.cardsToolStripMenuItem.Click += new System.EventHandler(this.cardsToolStripMenuItem_Click);
            // 
            // eduLevelsToolStripMenuItem
            // 
            this.eduLevelsToolStripMenuItem.Name = "eduLevelsToolStripMenuItem";
            this.eduLevelsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.eduLevelsToolStripMenuItem.Text = "Edu Levels";
            this.eduLevelsToolStripMenuItem.Click += new System.EventHandler(this.eduLevelsToolStripMenuItem_Click);
            // 
            // specialtiesToolStripMenuItem
            // 
            this.specialtiesToolStripMenuItem.Name = "specialtiesToolStripMenuItem";
            this.specialtiesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.specialtiesToolStripMenuItem.Text = "Specialties";
            this.specialtiesToolStripMenuItem.Click += new System.EventHandler(this.specialtiesToolStripMenuItem_Click);
            // 
            // qualificationsToolStripMenuItem
            // 
            this.qualificationsToolStripMenuItem.Name = "qualificationsToolStripMenuItem";
            this.qualificationsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.qualificationsToolStripMenuItem.Text = "Qualifications";
            this.qualificationsToolStripMenuItem.Click += new System.EventHandler(this.qualificationsToolStripMenuItem_Click);
            // 
            // institutionsToolStripMenuItem
            // 
            this.institutionsToolStripMenuItem.Name = "institutionsToolStripMenuItem";
            this.institutionsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.institutionsToolStripMenuItem.Text = "Institutions";
            this.institutionsToolStripMenuItem.Click += new System.EventHandler(this.institutionsToolStripMenuItem_Click);
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.componentsToolStripMenuItem.Text = "Components";
            this.componentsToolStripMenuItem.Click += new System.EventHandler(this.componentsToolStripMenuItem_Click);
            // 
            // configurationsToolStripMenuItem
            // 
            this.configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            this.configurationsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.configurationsToolStripMenuItem.Text = "Configurations";
            this.configurationsToolStripMenuItem.Click += new System.EventHandler(this.configurationsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // ranksToolStripMenuItem
            // 
            this.ranksToolStripMenuItem.Name = "ranksToolStripMenuItem";
            this.ranksToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ranksToolStripMenuItem.Text = "Ranks";
            this.ranksToolStripMenuItem.Click += new System.EventHandler(this.ranksToolStripMenuItem_Click);
            // 
            // educationToolStripMenuItem
            // 
            this.educationToolStripMenuItem.Name = "educationToolStripMenuItem";
            this.educationToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.educationToolStripMenuItem.Text = "Education";
            this.educationToolStripMenuItem.Click += new System.EventHandler(this.educationToolStripMenuItem_Click);
            // 
            // documentTypesToolStripMenuItem
            // 
            this.documentTypesToolStripMenuItem.Name = "documentTypesToolStripMenuItem";
            this.documentTypesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.documentTypesToolStripMenuItem.Text = "Document Types";
            this.documentTypesToolStripMenuItem.Click += new System.EventHandler(this.documentTypesToolStripMenuItem_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            this.documentsToolStripMenuItem.Click += new System.EventHandler(this.documentsToolStripMenuItem_Click);
            // 
            // organizationsToolStripMenuItem
            // 
            this.organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
            this.organizationsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.organizationsToolStripMenuItem.Text = "Organizations";
            this.organizationsToolStripMenuItem.Click += new System.EventHandler(this.organizationsToolStripMenuItem_Click);
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
            this.Text = "Employee PC Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}