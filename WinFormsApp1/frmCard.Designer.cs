namespace WinFormsApp1
{
    partial class frmCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWorker = new System.Windows.Forms.Label();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWorker
            this.lblWorker.Location = new System.Drawing.Point(12, 12);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(80, 23);
            this.lblWorker.Text = "Worker:";

            // cbWorker
            this.cbWorker.Location = new System.Drawing.Point(98, 12);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(200, 21);
            this.cbWorker.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblBank
            this.lblBank.Location = new System.Drawing.Point(12, 39);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(80, 23);
            this.lblBank.Text = "Bank:";

            // cbBank
            this.cbBank.Location = new System.Drawing.Point(98, 39);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(200, 21);
            this.cbBank.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblCardNumber
            this.lblCardNumber.Location = new System.Drawing.Point(12, 66);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(80, 23);
            this.lblCardNumber.Text = "Card Number:";

            // txtCardNumber
            this.txtCardNumber.Location = new System.Drawing.Point(98, 66);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(200, 20);

            // lblIssueDate
            this.lblIssueDate.Location = new System.Drawing.Point(12, 93);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(80, 23);
            this.lblIssueDate.Text = "Issue Date:";

            // dtpIssueDate
            this.dtpIssueDate.Location = new System.Drawing.Point(98, 93);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpIssueDate.ShowCheckBox = true;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(98, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(179, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // frmCard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 160);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.cbBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.lblWorker);
            this.Name = "frmCard";
            this.Text = "Card";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}