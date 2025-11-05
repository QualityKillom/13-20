namespace WinFormsApp1;

public partial class frmEduLevel : Form
{
    private EduLevel eduLevel;

    public frmEduLevel(EduLevel e = null)
    {
        InitializeComponent();
        eduLevel = e ?? new EduLevel();
        if (e != null)
        {
            txtName.Text = e.Name;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название уровня образования обязательно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            eduLevel.Name = txtName.Text;

            if (eduLevel.Id == 0)
                eduLevel.Add();
            else
                eduLevel.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}