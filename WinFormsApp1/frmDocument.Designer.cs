namespace WinFormsApp1
{
    partial class frmDocument
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.ComboBox cbOrganization;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
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
            this.lblPerson = new System.Windows.Forms.Label();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblPerson
            this.lblPerson.Location = new System.Drawing.Point(12, 12);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(80, 23);
            this.lblPerson.Text = "Person:";

            // cbPerson
            this.cbPerson.Location = new System.Drawing.Point(98, 12);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(200, 21);
            this.cbPerson.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblDocumentType
            this.lblDocumentType.Location = new System.Drawing.Point(12, 39);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(80, 23);
            this.lblDocumentType.Text = "Document Type:";

            // cbDocumentType
            this.cbDocumentType.Location = new System.Drawing.Point(98, 39);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(200, 21);
            this.cbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblOrganization
            this.lblOrganization.Location = new System.Drawing.Point(12, 66);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(80, 23);
            this.lblOrganization.Text = "Organization:";

            // cbOrganization
            this.cbOrganization.Location = new System.Drawing.Point(98, 66);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(200, 21);
            this.cbOrganization.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblNumber
            this.lblNumber.Location = new System.Drawing.Point(12, 93);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(80, 23);
            this.lblNumber.Text = "Number:";

            // txtNumber
            this.txtNumber.Location = new System.Drawing.Point(98, 93);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 20);

            // lblIssueDate
            this.lblIssueDate.Location = new System.Drawing.Point(12, 120);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(80, 23);
            this.lblIssueDate.Text = "Issue Date:";

            // dtpIssueDate
            this.dtpIssueDate.Location = new System.Drawing.Point(98, 120);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpIssueDate.ShowCheckBox = true;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(98, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(179, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // frmDocument
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.cbOrganization);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.cbDocumentType);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.cbPerson);
            this.Controls.Add(this.lblPerson);
            this.Name = "frmDocument";
            this.Text = "Document";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}