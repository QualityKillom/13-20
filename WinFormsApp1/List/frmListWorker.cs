
namespace WinFormsApp1
{
    public partial class frmListWorker : Form
    {
        public frmListWorker()
        {
            InitializeComponent();
        }

        private void frmListWorker_Load(object sender, EventArgs e)
        {
            LoadWorkers();
        }

        private void LoadWorkers()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT w.*, p.LastName, p.FirstName, r.Title AS RankTitle " +
                                   "FROM Worker w " +
                                   "JOIN Person p ON w.PersonId = p.Id " +
                                   "JOIN Rank r ON w.RankId = r.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvWorkers.DataSource = dt;
                        dgvWorkers.Columns["Id"].HeaderText = "ID";
                        dgvWorkers.Columns["PersonId"].Visible = false;
                        dgvWorkers.Columns["RankId"].Visible = false;
                        dgvWorkers.Columns["LastName"].HeaderText = "Last Name";
                        dgvWorkers.Columns["FirstName"].HeaderText = "First Name";
                        dgvWorkers.Columns["RankTitle"].HeaderText = "Rank";
                        dgvWorkers.Columns["HireDate"].HeaderText = "Hire Date";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading workers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmWorker form = new frmWorker();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadWorkers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWorkers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvWorkers.SelectedRows[0].Cells["Id"].Value);
                frmWorker form = new frmWorker(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadWorkers();
                }
            }
            else
            {
                MessageBox.Show("Please select a worker to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWorkers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this worker?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvWorkers.SelectedRows[0].Cells["Id"].Value);
                        Worker worker = new Worker { Id = id };
                        worker.Delete();
                        LoadWorkers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting worker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a worker to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}