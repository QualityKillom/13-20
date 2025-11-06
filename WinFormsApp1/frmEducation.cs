using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmEducation : Form
    {
        private Education education;

        public frmEducation(Education e = null)
        {
            InitializeComponent();
            education = e ?? new Education();
            LoadComboBoxes();
            if (e != null)
            {
                cmbWorkerId.SelectedValue = e.WorkerId;
                cmbEduLevelId.SelectedValue = e.EduLevelId;
                cmbSpecialtyId.SelectedValue = e.SpecialtyId;
                cmbQualificationId.SelectedValue = e.QualificationId;
                cmbInstitutionId.SelectedValue = e.InstitutionId;
                txtGraduationYear.Text = e.GraduationYear?.ToString() ?? "";
            }
        }

       private void LoadComboBoxes()
{
    using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
    {
        conn.Open();

        // ✅ Worker (берём ФИО из Person)
        string workerQuery = @"
            SELECT w.Id,
                   p.LastName || ' ' || p.FirstName AS FullName
            FROM Worker w
            JOIN Person p ON w.PersonId = p.Id
            ORDER BY p.LastName, p.FirstName;
        ";
        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(workerQuery, conn))
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbWorkerId.DataSource = dt;
            cmbWorkerId.DisplayMember = "FullName";
            cmbWorkerId.ValueMember = "Id";
        }

        // EduLevel
        string eduLevelQuery = "SELECT Id, Name FROM EduLevel";
        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(eduLevelQuery, conn))
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbEduLevelId.DataSource = dt;
            cmbEduLevelId.DisplayMember = "Name";
            cmbEduLevelId.ValueMember = "Id";
        }

        // Specialty
        string specialtyQuery = "SELECT Id, Name FROM Specialty";
        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(specialtyQuery, conn))
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbSpecialtyId.DataSource = dt;
            cmbSpecialtyId.DisplayMember = "Name";
            cmbSpecialtyId.ValueMember = "Id";
        }

        // Qualification
        string qualificationQuery = "SELECT Id, Name FROM Qualification";
        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(qualificationQuery, conn))
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbQualificationId.DataSource = dt;
            cmbQualificationId.DisplayMember = "Name";
            cmbQualificationId.ValueMember = "Id";
        }

        // EducationalInstitution
        string institutionQuery = "SELECT Id, Name FROM EducationalInstitution";
        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(institutionQuery, conn))
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbInstitutionId.DataSource = dt;
            cmbInstitutionId.DisplayMember = "Name";
            cmbInstitutionId.ValueMember = "Id";
        }
    }
}


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbWorkerId.SelectedValue == null || cmbEduLevelId.SelectedValue == null ||
                    cmbSpecialtyId.SelectedValue == null || cmbQualificationId.SelectedValue == null ||
                    cmbInstitutionId.SelectedValue == null)
                {
                    MessageBox.Show("Все идентификаторы обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                education.WorkerId = Convert.ToInt32(cmbWorkerId.SelectedValue);
                education.EduLevelId = Convert.ToInt32(cmbEduLevelId.SelectedValue);
                education.SpecialtyId = Convert.ToInt32(cmbSpecialtyId.SelectedValue);
                education.QualificationId = Convert.ToInt32(cmbQualificationId.SelectedValue);
                education.InstitutionId = Convert.ToInt32(cmbInstitutionId.SelectedValue);
                education.GraduationYear = string.IsNullOrWhiteSpace(txtGraduationYear.Text) ? null : (int?)Convert.ToInt32(txtGraduationYear.Text);

                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    if (education.Id == 0)
                    {
                        string query = "INSERT INTO Education (WorkerId, EduLevelId, SpecialtyId, QualificationId, InstitutionId, GraduationYear) VALUES (@WorkerId, @EduLevelId, @SpecialtyId, @QualificationId, @InstitutionId, @GraduationYear) RETURNING Id";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@WorkerId", education.WorkerId);
                            cmd.Parameters.AddWithValue("@EduLevelId", education.EduLevelId);
                            cmd.Parameters.AddWithValue("@SpecialtyId", education.SpecialtyId);
                            cmd.Parameters.AddWithValue("@QualificationId", education.QualificationId);
                            cmd.Parameters.AddWithValue("@InstitutionId", education.InstitutionId);
                            cmd.Parameters.AddWithValue("@GraduationYear", education.GraduationYear ?? (object)DBNull.Value);
                            education.Id = (int)cmd.ExecuteScalar(); // Получаем новый Id
                        }
                    }
                    else
                    {
                        education.Update();
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}