namespace WinFormsApp1;

public partial class frmSpecialty : Form
{
    private Specialty specialty;

    public frmSpecialty(Specialty s = null)
    {
        InitializeComponent();
        specialty = s ?? new Specialty();
        if (s != null)
        {
            txtName.Text = s.Name;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название специальности обязательно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            specialty.Name = txtName.Text;

            if (specialty.Id == 0)
                specialty.Add();
            else
                specialty.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}