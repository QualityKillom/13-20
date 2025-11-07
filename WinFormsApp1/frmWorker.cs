namespace WinFormsApp1
{
    public partial class frmWorker : Form
    {
        private int? _id;

        public frmWorker(int? id = null)
        {
            InitializeComponent();
            _id = id;
            LoadComboBoxes();
            if (_id.HasValue)
            {
                LoadWorker();
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    // Load Persons
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT Id, LastName, FirstName FROM Person", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbPerson.DataSource = dt;
                        cmbPerson.DisplayMember = "LastName";
                        cmbPerson.ValueMember = "Id";
                    }
                    // Load Ranks
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT Id, Title FROM Rank", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbRank.DataSource = dt;
                        cmbRank.DisplayMember = "Title";
                        cmbRank.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading combo boxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWorker()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Worker WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", _id.Value);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmbPerson.SelectedValue = Convert.ToInt32(reader["PersonId"]);
                                cmbRank.SelectedValue = Convert.ToInt32(reader["RankId"]);
                                dtpHireDate.Value = Convert.ToDateTime(reader["HireDate"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading worker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Worker worker = new Worker
                {
                    Id = _id ?? 0,
                    PersonId = Convert.ToInt32(cmbPerson.SelectedValue),
                    RankId = Convert.ToInt32(cmbRank.SelectedValue),
                    HireDate = dtpHireDate.Value
                };
                worker.Add();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving worker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}