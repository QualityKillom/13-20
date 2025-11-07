namespace WinFormsApp1
{
    public partial class frmBank : Form
    {
        private int? id;

        public frmBank(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id.HasValue)
            {
                LoadBank();
            }
        }

        private void LoadBank()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Bank WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id.Value);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader.GetString("Name");
                                txtBIC.Text = reader.IsDBNull(reader.GetOrdinal("BIC")) ? "" : reader.GetString("BIC");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bank: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Bank bank = new Bank
                {
                    Id = id ?? 0,
                    Name = txtName.Text,
                    BIC = string.IsNullOrWhiteSpace(txtBIC.Text) ? null : txtBIC.Text
                };

                if (id.HasValue)
                {
                    bank.Update();
                }
                else
                {
                    bank.Add();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving bank: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}