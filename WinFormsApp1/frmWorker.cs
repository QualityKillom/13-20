using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmWorker : Form
    {
        private Worker worker;

        public frmWorker(Worker w = null)
        {
            InitializeComponent();
            worker = w ?? new Worker();

            if (w != null)
            {
                txtPersonId.Text = w.PersonId.ToString();
                txtRankId.Text = w.RankId.ToString();
                dtpHireDate.Value = w.HireDate ?? DateTime.Now;
            }
            else
            {
                dtpHireDate.Value = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPersonId.Text, out int personId) ||
                    !int.TryParse(txtRankId.Text, out int rankId))
                {
                    MessageBox.Show("PersonId и RankId должны быть числами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                worker.PersonId = personId;
                worker.RankId = rankId;
                worker.HireDate = dtpHireDate.Value;

                if (worker.Id == 0)
                    worker.Add();
                else
                    worker.Update();

                MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}