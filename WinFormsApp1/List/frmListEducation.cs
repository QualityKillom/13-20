
namespace WinFormsApp1
{
    public partial class frmListEducation : Form
    {
        public frmListEducation()
        {
            InitializeComponent();
        }

        private void frmListEducation_Load(object sender, EventArgs e)
        {
            LoadEducation();
        }

        private void LoadEducation()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT e.*, p.LastName, p.FirstName, el.Name AS EduLevelName, s.Name AS SpecialtyName, q.Name AS QualificationName, ei.Name AS InstitutionName " +
                                   "FROM Education e " +
                                   "JOIN Worker w ON e.WorkerId = w.Id " +
                                   "JOIN Person p ON w.PersonId = p.Id " +
                                   "JOIN EduLevel el ON e.EduLevelId = el.Id " +
                                   "JOIN Specialty s ON e.SpecialtyId = s.Id " +
                                   "JOIN Qualification q ON e.QualificationId = q.Id " +
                                   "JOIN EducationalInstitution ei ON e.InstitutionId = ei.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEducation.DataSource = dt;
                        dgvEducation.Columns["Id"].HeaderText = "ID";
                        dgvEducation.Columns["WorkerId"].Visible = false;
                        dgvEducation.Columns["EduLevelId"].Visible = false;
                        dgvEducation.Columns["SpecialtyId"].Visible = false;
                        dgvEducation.Columns["QualificationId"].Visible = false;
                        dgvEducation.Columns["InstitutionId"].Visible = false;
                        dgvEducation.Columns["LastName"].HeaderText = "Last Name";
                        dgvEducation.Columns["FirstName"].HeaderText = "First Name";
                        dgvEducation.Columns["EduLevelName"].HeaderText = "Education Level";
                        dgvEducation.Columns["SpecialtyName"].HeaderText = "Specialty";
                        dgvEducation.Columns["QualificationName"].HeaderText = "Qualification";
                        dgvEducation.Columns["InstitutionName"].HeaderText = "Institution";
                        dgvEducation.Columns["GraduationYear"].HeaderText = "Graduation Year";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading education records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEducation form = new frmEducation();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEducation();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEducation.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEducation.SelectedRows[0].Cells["Id"].Value);
                frmEducation form = new frmEducation(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadEducation();
                }
            }
            else
            {
                MessageBox.Show("Please select an education record to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEducation.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this education record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvEducation.SelectedRows[0].Cells["Id"].Value);
                        Education education = new Education { Id = id };
                        education.Delete();
                        LoadEducation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting education record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an education record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}