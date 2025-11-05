namespace WinFormsApp1;

public partial class frmWorker : Form
{
    private Worker worker;

    public frmWorker(Worker w = null)
    {
        InitializeComponent();
        worker = w ?? new Worker();
        if (w != null)
        {
            // Предположим, что есть поля для PersonId, RankId, HireDate
            txtPersonId.Text = w.PersonId.ToString();
            txtRankId.Text = w.RankId.ToString();
            dtpHireDate.Value = w.HireDate ?? DateTime.Now;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtPersonId.Text) || string.IsNullOrWhiteSpace(txtRankId.Text))
            {
                MessageBox.Show("PersonId и RankId обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            worker.PersonId = Convert.ToInt32(txtPersonId.Text);
            worker.RankId = Convert.ToInt32(txtRankId.Text);
            worker.HireDate = dtpHireDate.Value;

            if (worker.Id == 0)
                worker.Add();
            else
                worker.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}