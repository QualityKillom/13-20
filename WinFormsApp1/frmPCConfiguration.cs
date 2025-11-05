namespace WinFormsApp1;

public partial class frmPCConfiguration : Form
{
    private PCConfiguration config;

    public frmPCConfiguration(PCConfiguration c = null)
    {
        InitializeComponent();
        config = c ?? new PCConfiguration();
        LoadComboBoxes();
        if (c != null)
        {
            cmbUser.SelectedValue = c.UserId;
            cmbComponent.SelectedValue = c.ComponentId;
            txtConfigurationName.Text = c.ConfigurationName;
            txtTotalPrice.Text = c.TotalPrice.ToString();
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
                // Компоненты
                string componentQuery = "SELECT Id, Name FROM Component";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(componentQuery, conn))
                {
                    DataTable dtComponent = new DataTable();
                    adapter.Fill(dtComponent);
                    cmbComponent.DataSource = dtComponent;
                    cmbComponent.DisplayMember = "Name";
                    cmbComponent.ValueMember = "Id";
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
            if (cmbUser.SelectedValue == null || cmbComponent.SelectedValue == null || string.IsNullOrWhiteSpace(txtConfigurationName.Text) || string.IsNullOrWhiteSpace(txtTotalPrice.Text))
            {
                MessageBox.Show("Все поля обязательны для заполнения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            config.UserId = Convert.ToInt32(cmbUser.SelectedValue);
            config.ComponentId = Convert.ToInt32(cmbComponent.SelectedValue);
            config.ConfigurationName = txtConfigurationName.Text;
            config.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);

            if (config.Id == 0)
                config.Add();
            else
                config.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}