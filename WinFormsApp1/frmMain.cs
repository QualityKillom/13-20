namespace WinFormsApp1;

public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPerson form = new frmListPerson();
            form.MdiParent = this;
            form.Show();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListWorker form = new frmListWorker();
            form.MdiParent = this;
            form.Show();
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBank form = new frmListBank();
            form.MdiParent = this;
            form.Show();
        }

        private void cardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCard form = new frmListCard();
            form.MdiParent = this;
            form.Show();
        }

        private void eduLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListEduLevel form = new frmListEduLevel();
            form.MdiParent = this;
            form.Show();
        }

        private void specialtiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSpecialty form = new frmListSpecialty();
            form.MdiParent = this;
            form.Show();
        }

        private void qualificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListQualification form = new frmListQualification();
            form.MdiParent = this;
            form.Show();
        }

        private void institutionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListEducationalInstitution form = new frmListEducationalInstitution();
            form.MdiParent = this;
            form.Show();
        }

        private void componentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListComponent form = new frmListComponent();
            form.MdiParent = this;
            form.Show();
        }

        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPCConfiguration form = new frmListPCConfiguration();
            form.MdiParent = this;
            form.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOrder form = new frmListOrder();
            form.MdiParent = this;
            form.Show();
        }
    }