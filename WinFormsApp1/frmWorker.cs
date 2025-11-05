namespace WinFormsApp1;

public partial class frmWorker : Form
{
    private Worker worker;

    public frmWorker(Worker w = null)
    {
        InitializeComponent();
        worker = w ?? new Worker();
        LoadComboBoxes();
        if (w != null)
        {
            cmbPerson.SelectedValue = w.PersonId;
            cmbRank.SelectedValue = w.RankId;
            dtpHireDate.Value = w.HireDate;
        }
    }

    private void LoadComboBoxes()
    {
        try
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                // Загрузка физлиц
                string personQuery = "SELECT Id, LastName || ' ' || FirstName || ' ' || COALESCE(MiddleName, '') AS FullName FROM Person";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(personQuery, conn))
                {
                    DataTable dtPerson = new DataTable();
                    adapter.Fill(dtPerson);
                    cmbPerson.DataSource = dtPerson;
                    cmbPerson.DisplayMember = "FullName";
                    cmbPerson.ValueMember = "Id";
                }

                // Загрузка должностей
                string rankQuery = "SELECT Id, Title FROM Rank";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(rankQuery, conn))
                {
                    DataTable dtRank = new DataTable();
                    adapter.Fill(dtRank);
                    cmbRank.DataSource = dtRank;
                    cmbRank.DisplayMember = "Title";
                    cmbRank.ValueMember = "Id";
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbPerson.SelectedValue == null || cmbRank.SelectedValue == null)
            {
                MessageBox.Show("Выберите физлицо и должность.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            worker.PersonId = Convert.ToInt32(cmbPerson.SelectedValue);
            worker.RankId = Convert.ToInt32(cmbRank.SelectedValue);
            worker.HireDate = dtpHireDate.Value;

            if (worker.Id == 0)
                worker.Add();
            else
                worker.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}