namespace WinFormsApp1;
    public partial class frmCard : Form
    {
        private Card card;

        public frmCard(Card c = null)
        {
            InitializeComponent();
            card = c ?? new Card();
            if (c != null)
            {
                txtWorkerId.Text = c.WorkerId.ToString();
                txtBankId.Text = c.BankId.ToString();
                txtCardNumber.Text = c.CardNumber;
                dtpIssueDate.Value = c.IssueDate ?? DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtWorkerId.Text) || string.IsNullOrWhiteSpace(txtBankId.Text) || string.IsNullOrWhiteSpace(txtCardNumber.Text))
                {
                    MessageBox.Show("WorkerId, BankId и CardNumber обязательны.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                card.WorkerId = Convert.ToInt32(txtWorkerId.Text);
                card.BankId = Convert.ToInt32(txtBankId.Text);
                card.CardNumber = txtCardNumber.Text;
                card.IssueDate = dtpIssueDate.Value;

                if (card.Id == 0)
                    card.Add();
                else
                    card.Update();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }