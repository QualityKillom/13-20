using Domain.Entities.MyTheme;

namespace WinFormsApp1.MyTheme
{
    public partial class frmRental : Form
    {
        private int? id;

        public frmRental(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            LoadPersons();
            LoadCars();
            LoadOrganizations();
            if (id.HasValue)
            {
                LoadRental();
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

        private void LoadCars()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Make || ' ' || Model AS CarName FROM Car WHERE IsAvailable = true";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbCar.DataSource = dt;
                        cbCar.DisplayMember = "CarName";
                        cbCar.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoadRental()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Rental WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id.Value);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cbPerson.SelectedValue = reader.GetInt32("PersonId");
                                cbCar.SelectedValue = reader.GetInt32("CarId");
                                cbOrganization.SelectedValue = reader.GetInt32("OrganizationId");
                                dtpStartDate.Value = reader.GetDateTime("StartDate");
                                dtpEndDate.Value = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? DateTime.Now : reader.GetDateTime("EndDate");
                                dtpEndDate.Checked = !reader.IsDBNull(reader.GetOrdinal("EndDate"));
                                numTotalCost.Value = reader.GetDecimal("TotalCost");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Rental rental = new Rental
                {
                    Id = id ?? 0,
                    PersonId = Convert.ToInt32(cbPerson.SelectedValue),
                    CarId = Convert.ToInt32(cbCar.SelectedValue),
                    OrganizationId = Convert.ToInt32(cbOrganization.SelectedValue),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Checked ? dtpEndDate.Value : (DateTime?)null,
                    TotalCost = numTotalCost.Value
                };

                if (id.HasValue)
                {
                    rental.Update();
                }
                else
                {
                    rental.Add();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}