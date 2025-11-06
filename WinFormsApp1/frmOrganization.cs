namespace WinFormsApp1;

public partial class frmOrganization : Form
{
    private Organization organization;

    public frmOrganization(Organization o = null)
    {
        InitializeComponent();
        organization = o ?? new Organization();
        if (o != null)
        {
            txtName.Text = o.Name ?? "";
            txtAddress.Text = o.Address ?? "";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название организации обязательно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            organization.Name = txtName.Text;
            organization.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;

            if (organization.Id == 0)
                organization.Add();
            else
                organization.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}