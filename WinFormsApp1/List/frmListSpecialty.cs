
namespace WinFormsApp1
{
    public partial class frmListSpecialty : Form
    {
        public frmListSpecialty()
        {
            InitializeComponent();
        }

        private void frmListSpecialty_Load(object sender, EventArgs e)
        {
            LoadSpecialties();
        }

        private void LoadSpecialties()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Specialty";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSpecialties.DataSource = dt;
                        dgvSpecialties.Columns["Id"].HeaderText = "ID";
                        dgvSpecialties.Columns["Name"].HeaderText = "Name";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading specialties: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSpecialty form = new frmSpecialty();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSpecialties();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSpecialties.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvSpecialties.SelectedRows[0].Cells["Id"].Value);
                frmSpecialty form = new frmSpecialty(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSpecialties();
                }
            }
            else
            {
                MessageBox.Show("Please select a specialty to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSpecialties.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this specialty?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvSpecialties.SelectedRows[0].Cells["Id"].Value);
                        Specialty specialty = new Specialty { Id = id };
                        specialty.Delete();
                        LoadSpecialties();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting specialty: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a specialty to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}