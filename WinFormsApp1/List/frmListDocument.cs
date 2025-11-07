

namespace WinFormsApp1
{
    public partial class frmListDocument : Form
    {
        public frmListDocument()
        {
            InitializeComponent();
        }

        private void frmListDocument_Load(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT d.*, p.LastName, p.FirstName, dt.Name AS DocumentTypeName, o.Name AS OrganizationName " +
                                   "FROM Document d " +
                                   "JOIN Person p ON d.PersonId = p.Id " +
                                   "JOIN DocumentType dt ON d.DocumentTypeId = dt.Id " +
                                   "JOIN Organization o ON d.OrganizationId = o.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvDocuments.DataSource = dt;
                        dgvDocuments.Columns["Id"].HeaderText = "ID";
                        dgvDocuments.Columns["PersonId"].Visible = false;
                        dgvDocuments.Columns["DocumentTypeId"].Visible = false;
                        dgvDocuments.Columns["OrganizationId"].Visible = false;
                        dgvDocuments.Columns["LastName"].HeaderText = "Last Name";
                        dgvDocuments.Columns["FirstName"].HeaderText = "First Name";
                        dgvDocuments.Columns["DocumentTypeName"].HeaderText = "Document Type";
                        dgvDocuments.Columns["OrganizationName"].HeaderText = "Organization";
                        dgvDocuments.Columns["Number"].HeaderText = "Number";
                        dgvDocuments.Columns["IssueDate"].HeaderText = "Issue Date";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading documents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDocument form = new frmDocument();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDocuments();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDocuments.SelectedRows[0].Cells["Id"].Value);
                frmDocument form = new frmDocument(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDocuments();
                }
            }
            else
            {
                MessageBox.Show("Please select a document to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this document?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvDocuments.SelectedRows[0].Cells["Id"].Value);
                        Document document = new Document { Id = id };
                        document.Delete();
                        LoadDocuments();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a document to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}