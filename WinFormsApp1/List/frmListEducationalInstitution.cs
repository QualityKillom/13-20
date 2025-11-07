
namespace WinFormsApp1
{
    public partial class frmListEducationalInstitution : Form
    {
        public frmListEducationalInstitution()
        {
            InitializeComponent();
        }

        private void frmListEducationalInstitution_Load(object sender, EventArgs e)
        {
            LoadInstitutions();
        }

        private void LoadInstitutions()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM EducationalInstitution";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvInstitutions.DataSource = dt;
                        dgvInstitutions.Columns["Id"].HeaderText = "ID";
                        dgvInstitutions.Columns["Name"].HeaderText = "Name";
                        dgvInstitutions.Columns["Address"].HeaderText = "Address";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading institutions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEducationalInstitution form = new frmEducationalInstitution();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadInstitutions();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInstitutions.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvInstitutions.SelectedRows[0].Cells["Id"].Value);
                frmEducationalInstitution form = new frmEducationalInstitution(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadInstitutions();
                }
            }
            else
            {
                MessageBox.Show("Please select an institution to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInstitutions.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this institution?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvInstitutions.SelectedRows[0].Cells["Id"].Value);
                        EducationalInstitution institution = new EducationalInstitution { Id = id };
                        institution.Delete();
                        LoadInstitutions();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting institution: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an institution to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}