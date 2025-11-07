
namespace WinFormsApp1
{
    public partial class frmEducation : Form
    {
        private int? _id;

        public frmEducation(int? id = null)
        {
            InitializeComponent();
            _id = id;
            LoadComboBoxes();
            if (_id.HasValue)
            {
                LoadEducation();
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    // Load Workers (via Person)
                    string workerQuery = "SELECT w.Id, p.LastName, p.FirstName FROM Worker w JOIN Person p ON w.PersonId = p.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(workerQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbWorker.DataSource = dt;
                        cmbWorker.DisplayMember = "LastName";
                        cmbWorker.ValueMember = "Id";
                    }
                    // Load EduLevels
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT Id, Name FROM EduLevel", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbEduLevel.DataSource = dt;
                        cmbEduLevel.DisplayMember = "Name";
                        cmbEduLevel.ValueMember = "Id";
                    }
                    // Load Specialties
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT Id, Name FROM Specialty", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbSpecialty.DataSource = dt;
                        cmbSpecialty.DisplayMember = "Name";
                        cmbSpecialty.ValueMember = "Id";
                    }
                    // Load Qualifications
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT Id, Name FROM Qualification", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbQualification.DataSource = dt;
                        cmbQualification.DisplayMember = "Name";
                        cmbQualification.ValueMember = "Id";
                    }
                    // Load EducationalInstitutions
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT Id, Name FROM EducationalInstitution", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbInstitution.DataSource = dt;
                        cmbInstitution.DisplayMember = "Name";
                        cmbInstitution.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading combo boxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEducation()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Education WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", _id.Value);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmbWorker.SelectedValue = Convert.ToInt32(reader["WorkerId"]);
                                cmbEduLevel.SelectedValue = Convert.ToInt32(reader["EduLevelId"]);
                                cmbSpecialty.SelectedValue = Convert.ToInt32(reader["SpecialtyId"]);
                                cmbQualification.SelectedValue = Convert.ToInt32(reader["QualificationId"]);
                                cmbInstitution.SelectedValue = Convert.ToInt32(reader["InstitutionId"]);
                                if (reader["GraduationYear"] != DBNull.Value)
                                    nudGraduationYear.Value = Convert.ToInt32(reader["GraduationYear"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading education: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Education education = new Education
                {
                    Id = _id ?? 0,
                    WorkerId = Convert.ToInt32(cmbWorker.SelectedValue),
                    EduLevelId = Convert.ToInt32(cmbEduLevel.SelectedValue),
                    SpecialtyId = Convert.ToInt32(cmbSpecialty.SelectedValue),
                    QualificationId = Convert.ToInt32(cmbQualification.SelectedValue),
                    InstitutionId = Convert.ToInt32(cmbInstitution.SelectedValue),
                    GraduationYear = nudGraduationYear.Value == 0 ? null : (int?)nudGraduationYear.Value
                };
                education.Add();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving education: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}