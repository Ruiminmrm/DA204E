namespace Upp5CD
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNewEvent = new System.Windows.Forms.GroupBox();
            this.txtCosstPerParticipant = new System.Windows.Forms.TextBox();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.lblFeePerParticipant = new System.Windows.Forms.Label();
            this.lblCostPerParticipant = new System.Windows.Forms.Label();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.txtFeePerParticipant = new System.Windows.Forms.TextBox();
            this.grpAddParticipant = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lstParticipant = new System.Windows.Forms.ListBox();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpEventEconomy = new System.Windows.Forms.GroupBox();
            this.lblresSurplus = new System.Windows.Forms.Label();
            this.lblresTotalFees = new System.Windows.Forms.Label();
            this.lblresTotalCost = new System.Windows.Forms.Label();
            this.lblResultNumParticipant = new System.Windows.Forms.Label();
            this.lblSurplus = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumberOfParticipant = new System.Windows.Forms.Label();
            this.grpNewEvent.SuspendLayout();
            this.grpAddParticipant.SuspendLayout();
            this.grpEventEconomy.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewEvent
            // 
            this.grpNewEvent.Controls.Add(this.txtCosstPerParticipant);
            this.grpNewEvent.Controls.Add(this.txtEventTitle);
            this.grpNewEvent.Controls.Add(this.lblFeePerParticipant);
            this.grpNewEvent.Controls.Add(this.lblCostPerParticipant);
            this.grpNewEvent.Controls.Add(this.lblEventTitle);
            this.grpNewEvent.Controls.Add(this.btnCreateEvent);
            this.grpNewEvent.ForeColor = System.Drawing.Color.Green;
            this.grpNewEvent.Location = new System.Drawing.Point(12, 12);
            this.grpNewEvent.Name = "grpNewEvent";
            this.grpNewEvent.Size = new System.Drawing.Size(283, 143);
            this.grpNewEvent.TabIndex = 0;
            this.grpNewEvent.TabStop = false;
            this.grpNewEvent.Text = "New Event";
            // 
            // txtCosstPerParticipant
            // 
            this.txtCosstPerParticipant.Location = new System.Drawing.Point(123, 54);
            this.txtCosstPerParticipant.Name = "txtCosstPerParticipant";
            this.txtCosstPerParticipant.Size = new System.Drawing.Size(154, 23);
            this.txtCosstPerParticipant.TabIndex = 4;
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(73, 25);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(204, 23);
            this.txtEventTitle.TabIndex = 1;
            // 
            // lblFeePerParticipant
            // 
            this.lblFeePerParticipant.AutoSize = true;
            this.lblFeePerParticipant.ForeColor = System.Drawing.Color.Black;
            this.lblFeePerParticipant.Location = new System.Drawing.Point(6, 83);
            this.lblFeePerParticipant.Name = "lblFeePerParticipant";
            this.lblFeePerParticipant.Size = new System.Drawing.Size(105, 15);
            this.lblFeePerParticipant.TabIndex = 3;
            this.lblFeePerParticipant.Text = "Fee per Participant";
            // 
            // lblCostPerParticipant
            // 
            this.lblCostPerParticipant.AutoSize = true;
            this.lblCostPerParticipant.ForeColor = System.Drawing.Color.Black;
            this.lblCostPerParticipant.Location = new System.Drawing.Point(6, 57);
            this.lblCostPerParticipant.Name = "lblCostPerParticipant";
            this.lblCostPerParticipant.Size = new System.Drawing.Size(111, 15);
            this.lblCostPerParticipant.TabIndex = 2;
            this.lblCostPerParticipant.Text = "Cost per Participant";
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.ForeColor = System.Drawing.Color.Black;
            this.lblEventTitle.Location = new System.Drawing.Point(6, 30);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(61, 15);
            this.lblEventTitle.TabIndex = 1;
            this.lblEventTitle.Text = "Event Title";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(85, 111);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(98, 23);
            this.btnCreateEvent.TabIndex = 1;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // txtFeePerParticipant
            // 
            this.txtFeePerParticipant.Location = new System.Drawing.Point(135, 95);
            this.txtFeePerParticipant.Name = "txtFeePerParticipant";
            this.txtFeePerParticipant.Size = new System.Drawing.Size(154, 23);
            this.txtFeePerParticipant.TabIndex = 5;
            // 
            // grpAddParticipant
            // 
            this.grpAddParticipant.Controls.Add(this.btnAdd);
            this.grpAddParticipant.Controls.Add(this.cmbCountry);
            this.grpAddParticipant.Controls.Add(this.txtZipCode);
            this.grpAddParticipant.Controls.Add(this.txtCity);
            this.grpAddParticipant.Controls.Add(this.txtStreet);
            this.grpAddParticipant.Controls.Add(this.txtLastName);
            this.grpAddParticipant.Controls.Add(this.txtFirstName);
            this.grpAddParticipant.Controls.Add(this.lblCountry);
            this.grpAddParticipant.Controls.Add(this.lblZipCode);
            this.grpAddParticipant.Controls.Add(this.lblCity);
            this.grpAddParticipant.Controls.Add(this.lblStreet);
            this.grpAddParticipant.Controls.Add(this.lblLastName);
            this.grpAddParticipant.Controls.Add(this.lblFirstName);
            this.grpAddParticipant.ForeColor = System.Drawing.Color.Green;
            this.grpAddParticipant.Location = new System.Drawing.Point(12, 161);
            this.grpAddParticipant.Name = "grpAddParticipant";
            this.grpAddParticipant.Size = new System.Drawing.Size(283, 214);
            this.grpAddParticipant.TabIndex = 6;
            this.grpAddParticipant.TabStop = false;
            this.grpAddParticipant.Text = "Add Participant";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(85, 153);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(192, 23);
            this.cmbCountry.TabIndex = 7;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(85, 128);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(192, 23);
            this.txtZipCode.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(85, 103);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(192, 23);
            this.txtCity.TabIndex = 13;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(85, 78);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(192, 23);
            this.txtStreet.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(85, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(192, 23);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(85, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(192, 23);
            this.txtFirstName.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(6, 156);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 15);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.ForeColor = System.Drawing.Color.Black;
            this.lblZipCode.Location = new System.Drawing.Point(6, 131);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(55, 15);
            this.lblZipCode.TabIndex = 9;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(6, 106);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.ForeColor = System.Drawing.Color.Black;
            this.lblStreet.Location = new System.Drawing.Point(6, 81);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(37, 15);
            this.lblStreet.TabIndex = 7;
            this.lblStreet.Text = "Street";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(6, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(6, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lstParticipant
            // 
            this.lstParticipant.FormattingEnabled = true;
            this.lstParticipant.ItemHeight = 15;
            this.lstParticipant.Location = new System.Drawing.Point(310, 37);
            this.lstParticipant.Name = "lstParticipant";
            this.lstParticipant.Size = new System.Drawing.Size(478, 109);
            this.lstParticipant.TabIndex = 7;
            this.lstParticipant.SelectedIndexChanged += new System.EventHandler(this.lstParticipant_SelectedIndexChanged);
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.ForeColor = System.Drawing.Color.Green;
            this.lblParticipant.Location = new System.Drawing.Point(310, 19);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(64, 15);
            this.lblParticipant.TabIndex = 5;
            this.lblParticipant.Text = "Participant";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Green;
            this.lblAddress.Location = new System.Drawing.Point(456, 19);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // btnChange
            // 
            this.btnChange.ForeColor = System.Drawing.Color.Green;
            this.btnChange.Location = new System.Drawing.Point(407, 152);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(98, 23);
            this.btnChange.TabIndex = 15;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Location = new System.Drawing.Point(595, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpEventEconomy
            // 
            this.grpEventEconomy.Controls.Add(this.lblresSurplus);
            this.grpEventEconomy.Controls.Add(this.lblresTotalFees);
            this.grpEventEconomy.Controls.Add(this.lblresTotalCost);
            this.grpEventEconomy.Controls.Add(this.lblResultNumParticipant);
            this.grpEventEconomy.Controls.Add(this.lblSurplus);
            this.grpEventEconomy.Controls.Add(this.lblTotalFees);
            this.grpEventEconomy.Controls.Add(this.lblTotalCost);
            this.grpEventEconomy.Controls.Add(this.lblNumberOfParticipant);
            this.grpEventEconomy.ForeColor = System.Drawing.Color.Green;
            this.grpEventEconomy.Location = new System.Drawing.Point(407, 192);
            this.grpEventEconomy.Name = "grpEventEconomy";
            this.grpEventEconomy.Size = new System.Drawing.Size(286, 129);
            this.grpEventEconomy.TabIndex = 17;
            this.grpEventEconomy.TabStop = false;
            this.grpEventEconomy.Text = "Event Economy";
            // 
            // lblresSurplus
            // 
            this.lblresSurplus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresSurplus.Location = new System.Drawing.Point(137, 100);
            this.lblresSurplus.Name = "lblresSurplus";
            this.lblresSurplus.Size = new System.Drawing.Size(138, 17);
            this.lblresSurplus.TabIndex = 7;
            // 
            // lblresTotalFees
            // 
            this.lblresTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresTotalFees.Location = new System.Drawing.Point(137, 75);
            this.lblresTotalFees.Name = "lblresTotalFees";
            this.lblresTotalFees.Size = new System.Drawing.Size(138, 17);
            this.lblresTotalFees.TabIndex = 6;
            // 
            // lblresTotalCost
            // 
            this.lblresTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresTotalCost.Location = new System.Drawing.Point(137, 50);
            this.lblresTotalCost.Name = "lblresTotalCost";
            this.lblresTotalCost.Size = new System.Drawing.Size(138, 17);
            this.lblresTotalCost.TabIndex = 5;
            // 
            // lblResultNumParticipant
            // 
            this.lblResultNumParticipant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultNumParticipant.Location = new System.Drawing.Point(137, 25);
            this.lblResultNumParticipant.Name = "lblResultNumParticipant";
            this.lblResultNumParticipant.Size = new System.Drawing.Size(138, 17);
            this.lblResultNumParticipant.TabIndex = 4;
            // 
            // lblSurplus
            // 
            this.lblSurplus.AutoSize = true;
            this.lblSurplus.Location = new System.Drawing.Point(6, 100);
            this.lblSurplus.Name = "lblSurplus";
            this.lblSurplus.Size = new System.Drawing.Size(84, 15);
            this.lblSurplus.TabIndex = 3;
            this.lblSurplus.Text = "Surplus/deficit";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(6, 75);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(58, 15);
            this.lblTotalFees.TabIndex = 2;
            this.lblTotalFees.Text = "Total Fees";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(6, 50);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(59, 15);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblNumberOfParticipant
            // 
            this.lblNumberOfParticipant.AutoSize = true;
            this.lblNumberOfParticipant.Location = new System.Drawing.Point(6, 25);
            this.lblNumberOfParticipant.Name = "lblNumberOfParticipant";
            this.lblNumberOfParticipant.Size = new System.Drawing.Size(125, 15);
            this.lblNumberOfParticipant.TabIndex = 0;
            this.lblNumberOfParticipant.Text = "Number of Participant";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.grpEventEconomy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblParticipant);
            this.Controls.Add(this.lstParticipant);
            this.Controls.Add(this.grpAddParticipant);
            this.Controls.Add(this.txtFeePerParticipant);
            this.Controls.Add(this.grpNewEvent);
            this.Name = "MainForm";
            this.Text = "Event By <Ruimin Ma>";
            this.grpNewEvent.ResumeLayout(false);
            this.grpNewEvent.PerformLayout();
            this.grpAddParticipant.ResumeLayout(false);
            this.grpAddParticipant.PerformLayout();
            this.grpEventEconomy.ResumeLayout(false);
            this.grpEventEconomy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpNewEvent;
        private Button btnCreateEvent;
        private TextBox txtCosstPerParticipant;
        private TextBox txtEventTitle;
        private Label lblFeePerParticipant;
        private Label lblCostPerParticipant;
        private Label lblEventTitle;
        private TextBox txtFeePerParticipant;
        private GroupBox grpAddParticipant;
        private Label lblZipCode;
        private Label lblCity;
        private Label lblStreet;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblCountry;
        private Button btnAdd;
        private ComboBox cmbCountry;
        private TextBox txtZipCode;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ListBox lstParticipant;
        private Label lblParticipant;
        private Label lblAddress;
        private Button btnChange;
        private Button btnDelete;
        private GroupBox grpEventEconomy;
        private Label lblSurplus;
        private Label lblTotalFees;
        private Label lblTotalCost;
        private Label lblNumberOfParticipant;
        private Label lblresSurplus;
        private Label lblresTotalFees;
        private Label lblresTotalCost;
        private Label lblResultNumParticipant;
    }
}