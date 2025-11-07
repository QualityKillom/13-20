
namespace WinFormsApp1
{
    public partial class frmListQualification : Form
    {
        public frmListQualification()
        {
            InitializeComponent();
        }

        private void frmListQualification_Load(object sender, EventArgs e)
        {
            LoadQualifications();
        }

        private void LoadQualifications()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Qualification";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvQualifications.DataSource = dt;
                        dgvQualifications.Columns["Id"].HeaderText = "ID";
                        dgvQualifications.Columns["Name"].HeaderText = "Name";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading qualifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmQualification form = new frmQualification();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadQualifications();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvQualifications.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvQualifications.SelectedRows[0].Cells["Id"].Value);
                frmQualification form = new frmQualification(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadQualifications();
                }
            }
            else
            {
                MessageBox.Show("Please select a qualification to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQualifications.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this qualification?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvQualifications.SelectedRows[0].Cells["Id"].Value);
                        Qualification qualification = new Qualification { Id = id };
                        qualification.Delete();
                        LoadQualifications();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting qualification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a qualification to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}