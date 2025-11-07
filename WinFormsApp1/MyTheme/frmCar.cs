using Domain.Entities.MyTheme;

namespace WinFormsApp1.MyTheme
{
    public partial class frmCar : Form
    {
        private int? id;

        public frmCar(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            LoadOrganizations();
            if (id.HasValue)
            {
                LoadCar();
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

        private void LoadCar()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Car WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id.Value);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cbOrganization.SelectedValue = reader.GetInt32("OrganizationId");
                                txtMake.Text = reader.GetString("Make");
                                txtModel.Text = reader.GetString("Model");
                                numYear.Value = reader.GetInt32("Year");
                                txtLicensePlate.Text = reader.GetString("LicensePlate");
                                numDailyRate.Value = reader.GetDecimal("DailyRate");
                                chkIsAvailable.Checked = reader.GetBoolean("IsAvailable");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car
                {
                    Id = id ?? 0,
                    OrganizationId = Convert.ToInt32(cbOrganization.SelectedValue),
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    Year = (int)numYear.Value,
                    LicensePlate = txtLicensePlate.Text,
                    DailyRate = numDailyRate.Value,
                    IsAvailable = chkIsAvailable.Checked
                };

                if (id.HasValue)
                {
                    car.Update();
                }
                else
                {
                    car.Add();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}