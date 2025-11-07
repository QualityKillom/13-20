
namespace WinFormsApp1
{
    public partial class frmListEduLevel : Form
    {
        public frmListEduLevel()
        {
            InitializeComponent();
        }

        private void frmListEduLevel_Load(object sender, EventArgs e)
        {
            LoadEduLevels();
        }

        private void LoadEduLevels()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM EduLevel";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEduLevels.DataSource = dt;
                        dgvEduLevels.Columns["Id"].HeaderText = "ID";
                        dgvEduLevels.Columns["Name"].HeaderText = "Name";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading education levels: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEduLevel form = new frmEduLevel();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEduLevels();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEduLevels.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEduLevels.SelectedRows[0].Cells["Id"].Value);
                frmEduLevel form = new frmEduLevel(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadEduLevels();
                }
            }
            else
            {
                MessageBox.Show("Please select an education level to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEduLevels.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this education level?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvEduLevels.SelectedRows[0].Cells["Id"].Value);
                        EduLevel eduLevel = new EduLevel { Id = id };
                        eduLevel.Delete();
                        LoadEduLevels();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting education level: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an education level to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}