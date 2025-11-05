namespace WinFormsApp1;

public partial class frmPerson : Form
{
    private Person person;

    public frmPerson(Person p = null)
    {
        InitializeComponent();
        person = p ?? new Person();
        if (p != null)
        {
            txtLastName.Text = p.LastName;
            txtFirstName.Text = p.FirstName;
            txtMiddleName.Text = p.MiddleName ?? "";
            txtPhone.Text = p.Phone ?? "";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Фамилия и имя обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            person.LastName = txtLastName.Text;
            person.FirstName = txtFirstName.Text;
            person.MiddleName = string.IsNullOrWhiteSpace(txtMiddleName.Text) ? null : txtMiddleName.Text;
            person.Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text;

            if (person.Id == 0)
                person.Add();
            else
                person.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
