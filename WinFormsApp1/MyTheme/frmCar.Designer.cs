namespace WinFormsApp1.MyTheme
{
    partial class frmCar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.ComboBox cbOrganization;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.NumericUpDown numDailyRate;
        private System.Windows.Forms.CheckBox chkIsAvailable;
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
            this.lblOrganization = new System.Windows.Forms.Label();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.numDailyRate = new System.Windows.Forms.NumericUpDown();
            this.chkIsAvailable = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyRate)).BeginInit();
            this.SuspendLayout();

            // lblOrganization
            this.lblOrganization.Location = new System.Drawing.Point(12, 12);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(80, 23);
            this.lblOrganization.Text = "Organization:";

            // cbOrganization
            this.cbOrganization.Location = new System.Drawing.Point(98, 12);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(200, 21);
            this.cbOrganization.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblMake
            this.lblMake.Location = new System.Drawing.Point(12, 39);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(80, 23);
            this.lblMake.Text = "Make:";

            // txtMake
            this.txtMake.Location = new System.Drawing.Point(98, 39);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(200, 20);

            // lblModel
            this.lblModel.Location = new System.Drawing.Point(12, 66);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(80, 23);
            this.lblModel.Text = "Model:";

            // txtModel
            this.txtModel.Location = new System.Drawing.Point(98, 66);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 20);

            // lblYear
            this.lblYear.Location = new System.Drawing.Point(12, 93);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(80, 23);
            this.lblYear.Text = "Year:";

            // numYear
            this.numYear.Location = new System.Drawing.Point(98, 93);
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(200, 20);
            this.numYear.Minimum = 1900;
            this.numYear.Maximum = 2100;

            // lblLicensePlate
            this.lblLicensePlate.Location = new System.Drawing.Point(12, 120);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(80, 23);
            this.lblLicensePlate.Text = "License Plate:";

            // txtLicensePlate
            this.txtLicensePlate.Location = new System.Drawing.Point(98, 120);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(200, 20);

            // lblDailyRate
            this.lblDailyRate.Location = new System.Drawing.Point(12, 147);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(80, 23);
            this.lblDailyRate.Text = "Daily Rate:";

            // numDailyRate
            this.numDailyRate.Location = new System.Drawing.Point(98, 147);
            this.numDailyRate.Name = "numDailyRate";
            this.numDailyRate.Size = new System.Drawing.Size(200, 20);
            this.numDailyRate.DecimalPlaces = 2;
            this.numDailyRate.Minimum = 0;
            this.numDailyRate.Maximum = 10000;

            // chkIsAvailable
            this.chkIsAvailable.Location = new System.Drawing.Point(98, 174);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Size = new System.Drawing.Size(200, 24);
            this.chkIsAvailable.Text = "Is Available";
            this.chkIsAvailable.Checked = true;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(98, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(179, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // frmCar
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 240);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsAvailable);
            this.Controls.Add(this.numDailyRate);
            this.Controls.Add(this.lblDailyRate);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.cbOrganization);
            this.Controls.Add(this.lblOrganization);
            this.Name = "frmCar";
            this.Text = "Car";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}