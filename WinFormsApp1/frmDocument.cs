
namespace WinFormsApp1
{
    public partial class frmDocument : Form
    {
        private int? id;

        public frmDocument(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            LoadPersons();
            LoadDocumentTypes();
            LoadOrganizations();
            if (id.HasValue)
            {
                LoadDocument();
            }
        }

        private void LoadPersons()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, LastName || ' ' || FirstName AS FullName FROM Person";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbPerson.DataSource = dt;
                        cbPerson.DisplayMember = "FullName";
                        cbPerson.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading persons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDocumentTypes()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name FROM DocumentType";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbDocumentType.DataSource = dt;
                        cbDocumentType.DisplayMember = "Name";
                        cbDocumentType.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading document types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrganizations()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name FROM Organization";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbOrganization.DataSource = dt;
                        cbOrganization.DisplayMember = "Name";
                        cbOrganization.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading organizations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDocument()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Document WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id.Value);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cbPerson.SelectedValue = reader.GetInt32("PersonId");
                                cbDocumentType.SelectedValue = reader.GetInt32("DocumentTypeId");
                                cbOrganization.SelectedValue = reader.GetInt32("OrganizationId");
                                txtNumber.Text = reader.GetString("Number");
                                dtpIssueDate.Value = reader.IsDBNull(reader.GetOrdinal("IssueDate")) ? DateTime.Now : reader.GetDateTime("IssueDate");
                                dtpIssueDate.Checked = !reader.IsDBNull(reader.GetOrdinal("IssueDate"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Document document = new Document
                {
                    Id = id ?? 0,
                    PersonId = Convert.ToInt32(cbPerson.SelectedValue),
                    DocumentTypeId = Convert.ToInt32(cbDocumentType.SelectedValue),
                    OrganizationId = Convert.ToInt32(cbOrganization.SelectedValue),
                    Number = txtNumber.Text,
                    IssueDate = dtpIssueDate.Checked ? dtpIssueDate.Value : (DateTime?)null
                };

                if (id.HasValue)
                {
                    document.Update();
                }
                else
                {
                    document.Add();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}