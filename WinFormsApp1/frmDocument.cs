namespace WinFormsApp1;

public partial class frmDocument : Form
{
    private Document document;

    public frmDocument(Document d = null)
    {
        InitializeComponent();
        document = d ?? new Document();
        if (d != null)
        {
            txtPersonId.Text = d.PersonId.ToString();
            txtDocumentTypeId.Text = d.DocumentTypeId.ToString();
            txtOrganizationId.Text = d.OrganizationId.ToString();
            txtNumber.Text = d.Number ?? "";
            dtpIssueDate.Value = d.IssueDate ?? DateTime.Now;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtPersonId.Text) || string.IsNullOrWhiteSpace(txtDocumentTypeId.Text) ||
                string.IsNullOrWhiteSpace(txtOrganizationId.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("Все поля обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            document.PersonId = Convert.ToInt32(txtPersonId.Text);
            document.DocumentTypeId = Convert.ToInt32(txtDocumentTypeId.Text);
            document.OrganizationId = Convert.ToInt32(txtOrganizationId.Text);
            document.Number = txtNumber.Text;
            document.IssueDate = dtpIssueDate.Value;

            if (document.Id == 0)
                document.Add();
            else
                document.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}