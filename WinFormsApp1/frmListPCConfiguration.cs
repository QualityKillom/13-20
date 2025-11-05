namespace WinFormsApp1;

public partial class frmListPCConfiguration : Form
    {
        public frmListPCConfiguration()
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
                    string query = "SELECT pc.Id, p.LastName, p.FirstName, c.Name AS ComponentName, pc.ConfigurationName, pc.TotalPrice FROM PCConfiguration pc JOIN Person p ON pc.UserId = p.Id JOIN Component c ON pc.ComponentId = c.Id";
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
            frmPCConfiguration form = new frmPCConfiguration();
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
                    PCConfiguration config = new PCConfiguration
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        UserId = Convert.ToInt32(row.Cells["UserId"].Value), // Предполагается наличие UserId
                        ComponentId = Convert.ToInt32(row.Cells["ComponentId"].Value), // Предполагается наличие ComponentId
                        ConfigurationName = row.Cells["ConfigurationName"].Value?.ToString(),
                        TotalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value)
                    };
                    frmPCConfiguration form = new frmPCConfiguration(config);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        PCConfiguration config = new PCConfiguration { Id = id };
                        config.Delete();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }