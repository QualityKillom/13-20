

namespace WinFormsApp1
{
    public partial class frmCard : Form
    {
        private int? id;

        public frmCard(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            LoadWorkers();
            LoadBanks();
            if (id.HasValue)
            {
                LoadCard();
            }
        }

        private void LoadWorkers()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT w.Id, p.LastName || ' ' || p.FirstName AS FullName " +
                                   "FROM Worker w JOIN Person p ON w.PersonId = p.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbWorker.DataSource = dt;
                        cbWorker.DisplayMember = "FullName";
                        cbWorker.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading workers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBanks()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name FROM Bank";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbBank.DataSource = dt;
                        cbBank.DisplayMember = "Name";
                        cbBank.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading banks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCard()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Card WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id.Value);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cbWorker.SelectedValue = reader.GetInt32("WorkerId");
                                cbBank.SelectedValue = reader.GetInt32("BankId");
                                txtCardNumber.Text = reader.GetString("CardNumber");
                                dtpIssueDate.Value = reader.IsDBNull(reader.GetOrdinal("IssueDate")) ? DateTime.Now : reader.GetDateTime("IssueDate");
                                dtpIssueDate.Checked = !reader.IsDBNull(reader.GetOrdinal("IssueDate"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading card: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Card card = new Card
                {
                    Id = id ?? 0,
                    WorkerId = Convert.ToInt32(cbWorker.SelectedValue),
                    BankId = Convert.ToInt32(cbBank.SelectedValue),
                    CardNumber = txtCardNumber.Text,
                    IssueDate = dtpIssueDate.Checked ? dtpIssueDate.Value : (DateTime?)null
                };

                if (id.HasValue)
                {
                    card.Update();
                }
                else
                {
                    card.Add();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving card: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}