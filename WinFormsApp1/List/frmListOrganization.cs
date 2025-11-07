
namespace WinFormsApp1
{
    public partial class frmListOrganization : Form
    {
        public frmListOrganization()
        {
            InitializeComponent();
        }

        private void frmListOrganization_Load(object sender, EventArgs e)
        {
            LoadOrganizations();
        }

        private void LoadOrganizations()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Organization";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvOrganizations.DataSource = dt;
                        dgvOrganizations.Columns["Id"].HeaderText = "ID";
                        dgvOrganizations.Columns["Name"].HeaderText = "Name";
                        dgvOrganizations.Columns["Address"].HeaderText = "Address";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading organizations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrganization form = new frmOrganization();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadOrganizations();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOrganizations.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvOrganizations.SelectedRows[0].Cells["Id"].Value);
                frmOrganization form = new frmOrganization(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadOrganizations();
                }
            }
            else
            {
                MessageBox.Show("Please select an organization to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrganizations.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this organization?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvOrganizations.SelectedRows[0].Cells["Id"].Value);
                        Organization organization = new Organization { Id = id };
                        organization.Delete();
                        LoadOrganizations();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting organization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an organization to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}