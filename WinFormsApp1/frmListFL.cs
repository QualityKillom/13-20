

namespace WinFormsApp1;

using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

public partial class frmListFL : Form
{
    public frmListFL()
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
                string query = "SELECT Id, LastName, FirstName, MiddleName, Phone FROM Person";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmFL form = new frmFL();
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
                Person person = new Person
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    LastName = row.Cells["LastName"].Value?.ToString(),
                    FirstName = row.Cells["FirstName"].Value?.ToString(),
                    MiddleName = row.Cells["MiddleName"].Value?.ToString(),
                    Phone = row.Cells["Phone"].Value?.ToString()
                };
                frmFL form = new frmFL(person);
                form.MdiParent = this.MdiParent;
                form.FormClosed += (s, args) => LoadData();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Выберите запись для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}