namespace WinFormsApp1;

public partial class frmListOrder : Form
{
    public frmListOrder()
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
                string query = "SELECT o.Id, u.LastName || ' ' || u.FirstName AS User, pc.ConfigurationName, o.OrderDate, o.Status " +
                              "FROM Order o " +
                              "JOIN User u ON o.UserId = u.Id " +
                              "JOIN PCConfiguration pc ON o.ConfigurationId = pc.Id";
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
        frmOrder form = new frmOrder();
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
                Order order = new Order
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    UserId = Convert.ToInt32(row.Cells["UserId"].Value), // Предполагаем, что UserId доступен
                    ConfigurationId = Convert.ToInt32(row.Cells["ConfigurationId"].Value), // Предполагаем, что ConfigurationId доступен
                    OrderDate = Convert.ToDateTime(row.Cells["OrderDate"].Value),
                    Status = row.Cells["Status"].Value?.ToString()
                };
                frmOrder form = new frmOrder(order);
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