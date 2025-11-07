namespace WinFormsApp1.List
{
    public partial class frmListDocumentType : Form
    {
        public frmListDocumentType()
        {
            InitializeComponent();
        }

        private void frmListDocumentType_Load(object sender, EventArgs e)
        {
            LoadDocumentTypes();
        }

        private void LoadDocumentTypes()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DocumentType";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvDocumentTypes.DataSource = dt;
                        dgvDocumentTypes.Columns["Id"].HeaderText = "ID";
                        dgvDocumentTypes.Columns["Name"].HeaderText = "Name";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading document types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDocumentType form = new frmDocumentType();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDocumentTypes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDocumentTypes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDocumentTypes.SelectedRows[0].Cells["Id"].Value);
                frmDocumentType form = new frmDocumentType(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDocumentTypes();
                }
            }
            else
            {
                MessageBox.Show("Please select a document type to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDocumentTypes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this document type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvDocumentTypes.SelectedRows[0].Cells["Id"].Value);
                        DocumentType documentType = new DocumentType { Id = id };
                        documentType.Delete();
                        LoadDocumentTypes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting document type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a document type to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}