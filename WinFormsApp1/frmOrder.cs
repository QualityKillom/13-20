namespace WinFormsApp1;

public partial class frmOrder : Form
{
    private Order order;

    public frmOrder(Order o = null)
    {
        InitializeComponent();
        order = o ?? new Order();
        if (o != null)
        {
            txtUserId.Text = o.UserId.ToString();
            txtConfigurationId.Text = o.ConfigurationId.ToString();
            dtpOrderDate.Value = o.OrderDate ?? DateTime.Now;
            txtStatus.Text = o.Status ?? "";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtConfigurationId.Text))
            {
                MessageBox.Show("UserId и ConfigurationId обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            order.UserId = Convert.ToInt32(txtUserId.Text);
            order.ConfigurationId = Convert.ToInt32(txtConfigurationId.Text);
            order.OrderDate = dtpOrderDate.Value;
            order.Status = string.IsNullOrWhiteSpace(txtStatus.Text) ? null : txtStatus.Text;

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