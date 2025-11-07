
namespace WinFormsApp1
{
    public partial class frmListRank : Form
    {
        public frmListRank()
        {
            InitializeComponent();
        }

        private void frmListRank_Load(object sender, EventArgs e)
        {
            LoadRanks();
        }

        private void LoadRanks()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Rank";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRanks.DataSource = dt;
                        dgvRanks.Columns["Id"].HeaderText = "ID";
                        dgvRanks.Columns["Title"].HeaderText = "Title";
                        dgvRanks.Columns["Salary"].HeaderText = "Salary";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ranks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRank form = new frmRank();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRanks();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRanks.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRanks.SelectedRows[0].Cells["Id"].Value);
                frmRank form = new frmRank(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadRanks();
                }
            }
            else
            {
                MessageBox.Show("Please select a rank to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRanks.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this rank?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvRanks.SelectedRows[0].Cells["Id"].Value);
                        Rank rank = new Rank { Id = id };
                        rank.Delete();
                        LoadRanks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting rank: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a rank to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}