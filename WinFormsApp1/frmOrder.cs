namespace WinFormsApp1;

public partial class frmOrder : Form
{
    private Order order;

    public frmOrder(Order o = null)
    {
        InitializeComponent();
        order = o ?? new Order();
        LoadComboBoxes();
        if (o != null)
        {
            cmbUser.SelectedValue = o.UserId;
            cmbConfiguration.SelectedValue = o.ConfigurationId;
            dtpOrderDate.Value = o.OrderDate;
            txtStatus.Text = o.Status;
        }
    }

    private void LoadComboBoxes()
    {
        try
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                // Пользователи
                string userQuery = "SELECT Id, LastName || ' ' || FirstName AS FullName FROM User";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(userQuery, conn))
                {
                    DataTable dtUser = new DataTable();
                    adapter.Fill(dtUser);
                    cmbUser.DataSource = dtUser;
                    cmbUser.DisplayMember = "FullName";
                    cmbUser.ValueMember = "Id";
                }
                // Конфигурации
                string configQuery = "SELECT Id, ConfigurationName FROM PCConfiguration";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(configQuery, conn))
                {
                    DataTable dtConfig = new DataTable();
                    adapter.Fill(dtConfig);
                    cmbConfiguration.DataSource = dtConfig;
                    cmbConfiguration.DisplayMember = "ConfigurationName";
                    cmbConfiguration.ValueMember = "Id";
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
            if (cmbUser.SelectedValue == null || cmbConfiguration.SelectedValue == null || string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Все поля обязательны для заполнения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            order.UserId = Convert.ToInt32(cmbUser.SelectedValue);
            order.ConfigurationId = Convert.ToInt32(cmbConfiguration.SelectedValue);
            order.OrderDate = dtpOrderDate.Value;
            order.Status = txtStatus.Text;

            if (order.Id == 0)
                order.Add();
            else
                order.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}