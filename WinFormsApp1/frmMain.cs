namespace WinFormsApp1;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }

    private void workersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmListWorker form = new frmListWorker();
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
