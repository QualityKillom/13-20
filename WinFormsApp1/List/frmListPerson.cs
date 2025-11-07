
namespace WinFormsApp1
{
    public partial class frmListPerson : Form
    {
        public frmListPerson()
        {
            InitializeComponent();
        }

        private void frmListPerson_Load(object sender, EventArgs e)
        {
            LoadPersons();
        }

        private void LoadPersons()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Person";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPersons.DataSource = dt;
                        dgvPersons.Columns["Id"].HeaderText = "ID";
                        dgvPersons.Columns["LastName"].HeaderText = "Last Name";
                        dgvPersons.Columns["FirstName"].HeaderText = "First Name";
                        dgvPersons.Columns["MiddleName"].HeaderText = "Middle Name";
                        dgvPersons.Columns["Phone"].HeaderText = "Phone";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading persons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPerson form = new frmPerson();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPersons();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPersons.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPersons.SelectedRows[0].Cells["Id"].Value);
                frmPerson form = new frmPerson(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPersons();
                }
            }
            else
            {
                MessageBox.Show("Please select a person to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPersons.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this person?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvPersons.SelectedRows[0].Cells["Id"].Value);
                        Person person = new Person { Id = id };
                        person.Delete();
                        LoadPersons();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a person to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}