namespace WinFormsApp1.List
{
    public partial class frmListBank : Form
    {
        public frmListBank()
        {
            InitializeComponent();
        }

        private void frmListBank_Load(object sender, EventArgs e)
        {
            LoadBanks();
        }

        private void LoadBanks()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Bank";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvBanks.DataSource = dt;
                        dgvBanks.Columns["Id"].HeaderText = "ID";
                        dgvBanks.Columns["Name"].HeaderText = "Name";
                        dgvBanks.Columns["BIC"].HeaderText = "BIC";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading banks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBank form = new frmBank();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBanks();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBanks.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvBanks.SelectedRows[0].Cells["Id"].Value);
                frmBank form = new frmBank(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadBanks();
                }
            }
            else
            {
                MessageBox.Show("Please select a bank to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBanks.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this bank?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvBanks.SelectedRows[0].Cells["Id"].Value);
                        Bank bank = new Bank { Id = id };
                        bank.Delete();
                        LoadBanks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting bank: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a bank to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}