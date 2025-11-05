namespace WinFormsApp1;

public partial class frmPCConfiguration : Form
{
    private PCConfiguration config;

    public frmPCConfiguration(PCConfiguration c = null)
    {
        InitializeComponent();
        config = c ?? new PCConfiguration();
        if (c != null)
        {
            txtUserId.Text = c.UserId.ToString();
            txtComponentId.Text = c.ComponentId.ToString();
            txtConfigurationName.Text = c.ConfigurationName ?? "";
            txtTotalPrice.Text = c.TotalPrice.ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtComponentId.Text) ||
                string.IsNullOrWhiteSpace(txtTotalPrice.Text))
            {
                MessageBox.Show("UserId, ComponentId и TotalPrice обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            config.UserId = Convert.ToInt32(txtUserId.Text);
            config.ComponentId = Convert.ToInt32(txtComponentId.Text);
            config.ConfigurationName = string.IsNullOrWhiteSpace(txtConfigurationName.Text) ? null : txtConfigurationName.Text;
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