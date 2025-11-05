namespace WinFormsApp1;

public partial class frmBank : Form
{
    private Bank bank;

    public frmBank(Bank b = null)
    {
        InitializeComponent();
        bank = b ?? new Bank();
        if (b != null)
        {
            txtName.Text = b.Name;
            txtBIC.Text = b.BIC ?? "";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название банка обязательно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bank.Name = txtName.Text;
            bank.BIC = string.IsNullOrWhiteSpace(txtBIC.Text) ? null : txtBIC.Text;

            if (bank.Id == 0)
                bank.Add();
            else
                bank.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
