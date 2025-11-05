namespace WinFormsApp1;

public partial class frmListCard : Form
    {
        public frmListCard()
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
                    string query = "SELECT c.Id, w.Id AS WorkerId, b.Name AS BankName, c.CardNumber, c.IssueDate FROM Card c JOIN Worker w ON c.WorkerId = w.Id JOIN Bank b ON c.BankId = b.Id";
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
            frmCard form = new frmCard();
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
                    Card card = new Card
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        WorkerId = Convert.ToInt32(row.Cells["WorkerId"].Value),
                        BankId = Convert.ToInt32(row.Cells["BankId"].Value), // Предполагается наличие BankId
                        CardNumber = row.Cells["CardNumber"].Value?.ToString(),
                        IssueDate = row.Cells["IssueDate"].Value != DBNull.Value ? (DateTime?)row.Cells["IssueDate"].Value : null
                    };
                    frmCard form = new frmCard(card);
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
                        Card card = new Card { Id = id };
                        card.Delete();
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