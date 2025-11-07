using Domain.Entities.MyTheme;

namespace WinFormsApp1.MyTheme
{
    public partial class frmListCar : Form
    {
        public frmListCar()
        {
            InitializeComponent();
        }

        private void frmListCar_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT c.*, o.Name AS OrganizationName FROM Car c JOIN Organization o ON c.OrganizationId = o.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCars.DataSource = dt;
                        dgvCars.Columns["Id"].HeaderText = "ID";
                        dgvCars.Columns["OrganizationId"].Visible = false;
                        dgvCars.Columns["OrganizationName"].HeaderText = "Organization";
                        dgvCars.Columns["Make"].HeaderText = "Make";
                        dgvCars.Columns["Model"].HeaderText = "Model";
                        dgvCars.Columns["Year"].HeaderText = "Year";
                        dgvCars.Columns["LicensePlate"].HeaderText = "License Plate";
                        dgvCars.Columns["DailyRate"].HeaderText = "Daily Rate";
                        dgvCars.Columns["IsAvailable"].HeaderText = "Available";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCar form = new frmCar();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCars();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Id"].Value);
                frmCar form = new frmCar(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCars();
                }
            }
            else
            {
                MessageBox.Show("Please select a car to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Id"].Value);
                        Car car = new Car { Id = id };
                        car.Delete();
                        LoadCars();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a car to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}