
namespace WinFormsApp1;

public partial class frmListWorker : Form
{
    public frmListWorker()
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
                string query = "SELECT w.Id, w.PersonId, p.LastName || ' ' || p.FirstName || ' ' || COALESCE(p.MiddleName, '') AS FullName, w.RankId, r.Title AS RankTitle, w.HireDate " +
                              "FROM Worker w " +
                              "JOIN Person p ON w.PersonId = p.Id " +
                              "JOIN Rank r ON w.RankId = r.Id";
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
        frmWorker form = new frmWorker();
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
                Worker worker = new Worker
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    PersonId = Convert.ToInt32(row.Cells["PersonId"].Value),
                    RankId = Convert.ToInt32(row.Cells["RankId"].Value),
                    HireDate = Convert.ToDateTime(row.Cells["HireDate"].Value)
                };
                frmWorker form = new frmWorker(worker);
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