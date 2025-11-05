namespace WinFormsApp1;

public partial class frmComponent : Form
{
    private Component component;

    public frmComponent(Component c = null)
    {
        InitializeComponent();
        component = c ?? new Component();
        if (c != null)
        {
            txtName.Text = c.Name;
            txtCategory.Text = c.Category;
            txtPrice.Text = c.Price.ToString();
            txtStockQuantity.Text = c.StockQuantity.ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtStockQuantity.Text))
            {
                MessageBox.Show("Все поля обязательны для заполнения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            component.Name = txtName.Text;
            component.Category = txtCategory.Text;
            component.Price = Convert.ToDecimal(txtPrice.Text);
            component.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);

            if (component.Id == 0)
                component.Add();
            else
                component.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}