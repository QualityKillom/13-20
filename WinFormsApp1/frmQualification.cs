namespace WinFormsApp1;

public partial class frmQualification : Form
{
    private Qualification qualification;

    public frmQualification(Qualification q = null)
    {
        InitializeComponent();
        qualification = q ?? new Qualification();
        if (q != null)
        {
            txtName.Text = q.Name;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название квалификации обязательно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            qualification.Name = txtName.Text;

            if (qualification.Id == 0)
                qualification.Add();
            else
                qualification.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}