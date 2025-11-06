namespace WinFormsApp1;

public partial class frmDocumentType : Form
{
    private DocumentType documentType;

    public frmDocumentType(DocumentType dt = null)
    {
        InitializeComponent();
        documentType = dt ?? new DocumentType();
        if (dt != null)
        {
            txtName.Text = dt.Name ?? "";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название типа документа обязательно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            documentType.Name = txtName.Text;

            if (documentType.Id == 0)
                documentType.Add();
            else
                documentType.Update();

            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}