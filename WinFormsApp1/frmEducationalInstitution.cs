namespace WinFormsApp1;

public partial class frmEducationalInstitution : Form
{
    private EducationalInstitution institution;

    public frmEducationalInstitution(EducationalInstitution i = null)
    {
        InitializeComponent();
        institution = i ?? new EducationalInstitution();
        if (i != null)
        {
            txtName.Text = i.Name ?? "";
            txtAddress.Text = i.Address ?? "";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название учебного заведения обязательно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            institution.Name = txtName.Text;
            institution.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;

            if (institution.Id == 0)
                institution.Add();
            else
                institution.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}