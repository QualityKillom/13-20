using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmListEducation : Form
    {
        public frmListEducation()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT e.Id, e.WorkerId, e.EduLevelId, e.SpecialtyId, e.QualificationId, e.InstitutionId, e.GraduationYear,
       p.LastName AS WorkerLastName, p.FirstName AS WorkerFirstName,
       el.Name AS EduLevelName, s.Name AS SpecialtyName,
       q.Name AS QualificationName, ei.Name AS InstitutionName
FROM Education e
JOIN Worker w ON e.WorkerId = w.Id
JOIN Person p ON w.PersonId = p.Id
JOIN EduLevel el ON e.EduLevelId = el.Id
JOIN Specialty s ON e.SpecialtyId = s.Id
JOIN Qualification q ON e.QualificationId = q.Id
JOIN EducationalInstitution ei ON e.InstitutionId = ei.Id
ORDER BY e.Id
";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        // Настройка столбцов DataGridView для лучшего отображения
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["WorkerId"].Visible = false;
                        dataGridView1.Columns["EduLevelId"].Visible = false;
                        dataGridView1.Columns["SpecialtyId"].Visible = false;
                        dataGridView1.Columns["QualificationId"].Visible = false;
                        dataGridView1.Columns["InstitutionId"].Visible = false;
                        dataGridView1.AutoResizeColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}\n" +
                                "Подробности: Убедитесь, что таблицы (Education, Worker, EduLevel, Specialty, Qualification, EducationalInstitution) существуют и содержат данные, а строка подключения верна.", 
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Опционально: Логирование ошибки в файл для отладки
                // System.IO.File.AppendAllText("error.log", $"[{DateTime.Now}] {ex.ToString()}\n");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEducation form = new frmEducation();
            form.MdiParent = this.MdiParent;
            form.FormClosed += (s, args) => LoadData();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    Education education = new Education
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        WorkerId = Convert.ToInt32(row.Cells["WorkerId"].Value),
                        EduLevelId = Convert.ToInt32(row.Cells["EduLevelId"].Value),
                        SpecialtyId = Convert.ToInt32(row.Cells["SpecialtyId"].Value),
                        QualificationId = Convert.ToInt32(row.Cells["QualificationId"].Value),
                        InstitutionId = Convert.ToInt32(row.Cells["InstitutionId"].Value),
                        GraduationYear = row.Cells["GraduationYear"].Value != DBNull.Value
                            ? (int?)Convert.ToInt32(row.Cells["GraduationYear"].Value)
                            : null
                    };
                    frmEducation form = new frmEducation(education);
                    form.MdiParent = this.MdiParent;
                    form.FormClosed += (s, args) => LoadData();
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при редактировании: {ex.Message}\n" +
                                    "Подробности: Проверьте выбранную запись и структуру таблицы.", 
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?",
                        "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        Education education = new Education { Id = id };
                        education.Delete();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}\n" +
                                    "Подробности: Проверьте права доступа или наличие связанных записей.", 
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}