namespace WinFormsApp1.MyTheme
{
    partial class frmRental
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.ComboBox cbOrganization;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.NumericUpDown numTotalCost;
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
            this.lblCar = new System.Windows.Forms.Label();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.numTotalCost = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).BeginInit();
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

            // lblCar
            this.lblCar.Location = new System.Drawing.Point(12, 39);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(80, 23);
            this.lblCar.Text = "Car:";

            // cbCar
            this.cbCar.Location = new System.Drawing.Point(98, 39);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(200, 21);
            this.cbCar.DropDownStyle = ComboBoxStyle.DropDownList;

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

            // lblStartDate
            this.lblStartDate.Location = new System.Drawing.Point(12, 93);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(80, 23);
            this.lblStartDate.Text = "Start Date:";

            // dtpStartDate
            this.dtpStartDate.Location = new System.Drawing.Point(98, 93);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);

            // lblEndDate
            this.lblEndDate.Location = new System.Drawing.Point(12, 120);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(80, 23);
            this.lblEndDate.Text = "End Date:";

            // dtpEndDate
            this.dtpEndDate.Location = new System.Drawing.Point(98, 120);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.ShowCheckBox = true;

            // lblTotalCost
            this.lblTotalCost.Location = new System.Drawing.Point(12, 147);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(80, 23);
            this.lblTotalCost.Text = "Total Cost:";

            // numTotalCost
            this.numTotalCost.Location = new System.Drawing.Point(98, 147);
            this.numTotalCost.Name = "numTotalCost";
            this.numTotalCost.Size = new System.Drawing.Size(200, 20);
            this.numTotalCost.DecimalPlaces = 2;
            this.numTotalCost.Minimum = 0;
            this.numTotalCost.Maximum = 100000;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(98, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(179, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // frmRental
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 210);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cbOrganization);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.cbPerson);
            this.Controls.Add(this.lblPerson);
            this.Name = "frmRental";
            this.Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}