using Domain.Entities.MyTheme;

namespace WinFormsApp1.MyTheme
{
    public partial class frmListRental : Form
    {
        public frmListRental()
        {
            InitializeComponent();
        }

        private void frmListRental_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void LoadRentals()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT r.*, p.LastName, p.FirstName, c.Make, c.Model, o.Name AS OrganizationName " +
                                   "FROM Rental r " +
                                   "JOIN Person p ON r.PersonId = p.Id " +
                                   "JOIN Car c ON r.CarId = c.Id " +
                                   "JOIN Organization o ON r.OrganizationId = o.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRentals.DataSource = dt;
                        dgvRentals.Columns["Id"].HeaderText = "ID";
                        dgvRentals.Columns["PersonId"].Visible = false;
                        dgvRentals.Columns["CarId"].Visible = false;
                        dgvRentals.Columns["OrganizationId"].Visible = false;
                        dgvRentals.Columns["LastName"].HeaderText = "Last Name";
                        dgvRentals.Columns["FirstName"].HeaderText = "First Name";
                        dgvRentals.Columns["Make"].HeaderText = "Car Make";
                        dgvRentals.Columns["Model"].HeaderText = "Car Model";
                        dgvRentals.Columns["OrganizationName"].HeaderText = "Organization";
                        dgvRentals.Columns["StartDate"].HeaderText = "Start Date";
                        dgvRentals.Columns["EndDate"].HeaderText = "End Date";
                        dgvRentals.Columns["TotalCost"].HeaderText = "Total Cost";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rentals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRental form = new frmRental();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRentals();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells["Id"].Value);
                frmRental form = new frmRental(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadRentals();
                }
            }
            else
            {
                MessageBox.Show("Please select a rental to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this rental?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells["Id"].Value);
                        Rental rental = new Rental { Id = id };
                        rental.Delete();
                        LoadRentals();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a rental to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}