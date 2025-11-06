namespace WinFormsApp1;

public partial class frmRank : Form
{
    private Rank rank;

    public frmRank(Rank r = null)
    {
        InitializeComponent();
        rank = r ?? new Rank();
        if (r != null)
        {
            txtTitle.Text = r.Title ?? "";
            txtSalary.Text = r.Salary.ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Название звания и зарплата обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rank.Title = txtTitle.Text;
            rank.Salary = decimal.Parse(txtSalary.Text);

            if (rank.Id == 0)
                rank.Add();
            else
                rank.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}