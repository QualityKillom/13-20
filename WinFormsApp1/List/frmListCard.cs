
namespace WinFormsApp1
{
    public partial class frmListCard : Form
    {
        public frmListCard()
        {
            InitializeComponent();
        }

        private void frmListCard_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void LoadCards()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT c.*, w.PersonId, p.LastName, p.FirstName, b.Name AS BankName " +
                                   "FROM Card c " +
                                   "JOIN Worker w ON c.WorkerId = w.Id " +
                                   "JOIN Person p ON w.PersonId = p.Id " +
                                   "JOIN Bank b ON c.BankId = b.Id";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCards.DataSource = dt;
                        dgvCards.Columns["Id"].HeaderText = "ID";
                        dgvCards.Columns["WorkerId"].Visible = false;
                        dgvCards.Columns["PersonId"].Visible = false;
                        dgvCards.Columns["BankId"].Visible = false;
                        dgvCards.Columns["LastName"].HeaderText = "Last Name";
                        dgvCards.Columns["FirstName"].HeaderText = "First Name";
                        dgvCards.Columns["BankName"].HeaderText = "Bank";
                        dgvCards.Columns["CardNumber"].HeaderText = "Card Number";
                        dgvCards.Columns["IssueDate"].HeaderText = "Issue Date";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cards: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCard form = new frmCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCards();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCards.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCards.SelectedRows[0].Cells["Id"].Value);
                frmCard form = new frmCard(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCards();
                }
            }
            else
            {
                MessageBox.Show("Please select a card to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCards.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this card?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvCards.SelectedRows[0].Cells["Id"].Value);
                        Card card = new Card { Id = id };
                        card.Delete();
                        LoadCards();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting card: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a card to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}