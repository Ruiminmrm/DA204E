namespace Upp3
{
    partial class Form
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
            this.BMICalcGroupBox = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.UnitGroupBox = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.Res = new System.Windows.Forms.Label();
            this.lblWeightCateResult = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.lblWeightCate = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.SavingPlanGroupBox = new System.Windows.Forms.GroupBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtGrowth = new System.Windows.Forms.TextBox();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.txtMonDes = new System.Windows.Forms.TextBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblMonDes = new System.Windows.Forms.Label();
            this.btnCalcSaving = new System.Windows.Forms.Button();
            this.FutureValGroupBox = new System.Windows.Forms.GroupBox();
            this.resTotalFees = new System.Windows.Forms.Label();
            this.resAmountEarned = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.resFinalBalans = new System.Windows.Forms.Label();
            this.resAmountPaid = new System.Windows.Forms.Label();
            this.lblFinalBalans = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.BMRGroupBox = new System.Windows.Forms.GroupBox();
            this.btnBMR = new System.Windows.Forms.Button();
            this.listBoxBMRRes = new System.Windows.Forms.ListBox();
            this.ActivLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.rbtnLevel5 = new System.Windows.Forms.RadioButton();
            this.rbtnLevel4 = new System.Windows.Forms.RadioButton();
            this.rbtnLevel3 = new System.Windows.Forms.RadioButton();
            this.rbtnLevel2 = new System.Windows.Forms.RadioButton();
            this.rbtnLevel1 = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.BMICalcGroupBox.SuspendLayout();
            this.UnitGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SavingPlanGroupBox.SuspendLayout();
            this.FutureValGroupBox.SuspendLayout();
            this.BMRGroupBox.SuspendLayout();
            this.ActivLevelGroupBox.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalcGroupBox
            // 
            this.BMICalcGroupBox.Controls.Add(this.txtWeight);
            this.BMICalcGroupBox.Controls.Add(this.txtHeight);
            this.BMICalcGroupBox.Controls.Add(this.txtName);
            this.BMICalcGroupBox.Controls.Add(this.lblWeight);
            this.BMICalcGroupBox.Controls.Add(this.lblHeight);
            this.BMICalcGroupBox.Controls.Add(this.lblName);
            this.BMICalcGroupBox.Location = new System.Drawing.Point(14, 16);
            this.BMICalcGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BMICalcGroupBox.Name = "BMICalcGroupBox";
            this.BMICalcGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BMICalcGroupBox.Size = new System.Drawing.Size(311, 133);
            this.BMICalcGroupBox.TabIndex = 0;
            this.BMICalcGroupBox.TabStop = false;
            this.BMICalcGroupBox.Text = "BMI Calculator";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(95, 91);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(178, 27);
            this.txtWeight.TabIndex = 5;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(95, 56);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(178, 27);
            this.txtHeight.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 27);
            this.txtName.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(7, 95);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(7, 61);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(54, 20);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // UnitGroupBox
            // 
            this.UnitGroupBox.Controls.Add(this.rbtnImperial);
            this.UnitGroupBox.Controls.Add(this.rbtnMetric);
            this.UnitGroupBox.Location = new System.Drawing.Point(334, 16);
            this.UnitGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnitGroupBox.Name = "UnitGroupBox";
            this.UnitGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnitGroupBox.Size = new System.Drawing.Size(174, 133);
            this.UnitGroupBox.TabIndex = 1;
            this.UnitGroupBox.TabStop = false;
            this.UnitGroupBox.Text = "Unit";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(21, 76);
            this.rbtnImperial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(152, 24);
            this.rbtnImperial.TabIndex = 1;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial(inch , lbs)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(21, 43);
            this.rbtnMetric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(129, 24);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric(kg , cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(147, 157);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(205, 31);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate BMI";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.Res);
            this.ResultGroupBox.Controls.Add(this.lblWeightCateResult);
            this.ResultGroupBox.Controls.Add(this.lblBMIResult);
            this.ResultGroupBox.Controls.Add(this.lblWeightCate);
            this.ResultGroupBox.Controls.Add(this.lblBMI);
            this.ResultGroupBox.Location = new System.Drawing.Point(14, 196);
            this.ResultGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultGroupBox.Size = new System.Drawing.Size(494, 164);
            this.ResultGroupBox.TabIndex = 3;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Results for <>";
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Location = new System.Drawing.Point(7, 119);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(0, 20);
            this.Res.TabIndex = 4;
            // 
            // lblWeightCateResult
            // 
            this.lblWeightCateResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCateResult.Location = new System.Drawing.Point(146, 73);
            this.lblWeightCateResult.Name = "lblWeightCateResult";
            this.lblWeightCateResult.Size = new System.Drawing.Size(285, 31);
            this.lblWeightCateResult.TabIndex = 3;
            this.lblWeightCateResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIResult.Location = new System.Drawing.Point(146, 37);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(285, 31);
            this.lblBMIResult.TabIndex = 2;
            this.lblBMIResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightCate
            // 
            this.lblWeightCate.AutoSize = true;
            this.lblWeightCate.Location = new System.Drawing.Point(7, 73);
            this.lblWeightCate.Name = "lblWeightCate";
            this.lblWeightCate.Size = new System.Drawing.Size(120, 20);
            this.lblWeightCate.TabIndex = 1;
            this.lblWeightCate.Text = "Weight Category";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(7, 37);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(35, 20);
            this.lblBMI.TabIndex = 0;
            this.lblBMI.Text = "BMI";
            // 
            // SavingPlanGroupBox
            // 
            this.SavingPlanGroupBox.Controls.Add(this.lblFees);
            this.SavingPlanGroupBox.Controls.Add(this.lblGrowth);
            this.SavingPlanGroupBox.Controls.Add(this.txtFees);
            this.SavingPlanGroupBox.Controls.Add(this.txtGrowth);
            this.SavingPlanGroupBox.Controls.Add(this.txtPer);
            this.SavingPlanGroupBox.Controls.Add(this.txtMonDes);
            this.SavingPlanGroupBox.Controls.Add(this.lblPer);
            this.SavingPlanGroupBox.Controls.Add(this.lblMonDes);
            this.SavingPlanGroupBox.Location = new System.Drawing.Point(531, 16);
            this.SavingPlanGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SavingPlanGroupBox.Name = "SavingPlanGroupBox";
            this.SavingPlanGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SavingPlanGroupBox.Size = new System.Drawing.Size(617, 133);
            this.SavingPlanGroupBox.TabIndex = 4;
            this.SavingPlanGroupBox.TabStop = false;
            this.SavingPlanGroupBox.Text = "Saving Plan";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(283, 91);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(70, 20);
            this.lblFees.TabIndex = 7;
            this.lblFees.Text = "Fees in %";
            // 
            // lblGrowth
            // 
            this.lblGrowth.AutoSize = true;
            this.lblGrowth.Location = new System.Drawing.Point(283, 53);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(170, 20);
            this.lblGrowth.TabIndex = 6;
            this.lblGrowth.Text = "Growth (or interest) in %";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(457, 85);
            this.txtFees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(142, 27);
            this.txtFees.TabIndex = 5;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGrowth
            // 
            this.txtGrowth.Location = new System.Drawing.Point(457, 47);
            this.txtGrowth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrowth.Name = "txtGrowth";
            this.txtGrowth.Size = new System.Drawing.Size(142, 27);
            this.txtGrowth.TabIndex = 4;
            this.txtGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPer
            // 
            this.txtPer.Location = new System.Drawing.Point(134, 84);
            this.txtPer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(142, 27);
            this.txtPer.TabIndex = 3;
            this.txtPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonDes
            // 
            this.txtMonDes.Location = new System.Drawing.Point(134, 43);
            this.txtMonDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonDes.Name = "txtMonDes";
            this.txtMonDes.Size = new System.Drawing.Size(142, 27);
            this.txtMonDes.TabIndex = 2;
            this.txtMonDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(7, 84);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(103, 20);
            this.lblPer.TabIndex = 1;
            this.lblPer.Text = "Period (years) ";
            // 
            // lblMonDes
            // 
            this.lblMonDes.AutoSize = true;
            this.lblMonDes.Location = new System.Drawing.Point(7, 47);
            this.lblMonDes.Name = "lblMonDes";
            this.lblMonDes.Size = new System.Drawing.Size(123, 20);
            this.lblMonDes.TabIndex = 0;
            this.lblMonDes.Text = "Monthly desposit";
            // 
            // btnCalcSaving
            // 
            this.btnCalcSaving.Location = new System.Drawing.Point(738, 157);
            this.btnCalcSaving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcSaving.Name = "btnCalcSaving";
            this.btnCalcSaving.Size = new System.Drawing.Size(205, 31);
            this.btnCalcSaving.TabIndex = 5;
            this.btnCalcSaving.Text = "Calculate Saving";
            this.btnCalcSaving.UseVisualStyleBackColor = true;
            this.btnCalcSaving.Click += new System.EventHandler(this.btnCalcSaving_Click);
            // 
            // FutureValGroupBox
            // 
            this.FutureValGroupBox.Controls.Add(this.resTotalFees);
            this.FutureValGroupBox.Controls.Add(this.resAmountEarned);
            this.FutureValGroupBox.Controls.Add(this.label3);
            this.FutureValGroupBox.Controls.Add(this.lblAmountEarned);
            this.FutureValGroupBox.Controls.Add(this.resFinalBalans);
            this.FutureValGroupBox.Controls.Add(this.resAmountPaid);
            this.FutureValGroupBox.Controls.Add(this.lblFinalBalans);
            this.FutureValGroupBox.Controls.Add(this.lblAmountPaid);
            this.FutureValGroupBox.Location = new System.Drawing.Point(531, 196);
            this.FutureValGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FutureValGroupBox.Name = "FutureValGroupBox";
            this.FutureValGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FutureValGroupBox.Size = new System.Drawing.Size(617, 164);
            this.FutureValGroupBox.TabIndex = 6;
            this.FutureValGroupBox.TabStop = false;
            this.FutureValGroupBox.Text = "Future Value";
            // 
            // resTotalFees
            // 
            this.resTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resTotalFees.Location = new System.Drawing.Point(418, 73);
            this.resTotalFees.Name = "resTotalFees";
            this.resTotalFees.Size = new System.Drawing.Size(182, 31);
            this.resTotalFees.TabIndex = 7;
            this.resTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resAmountEarned
            // 
            this.resAmountEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resAmountEarned.Location = new System.Drawing.Point(418, 32);
            this.resAmountEarned.Name = "resAmountEarned";
            this.resAmountEarned.Size = new System.Drawing.Size(182, 31);
            this.resAmountEarned.TabIndex = 6;
            this.resAmountEarned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Fees";
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.Location = new System.Drawing.Point(309, 37);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(112, 20);
            this.lblAmountEarned.TabIndex = 4;
            this.lblAmountEarned.Text = "Amount Earned";
            // 
            // resFinalBalans
            // 
            this.resFinalBalans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resFinalBalans.Location = new System.Drawing.Point(112, 73);
            this.resFinalBalans.Name = "resFinalBalans";
            this.resFinalBalans.Size = new System.Drawing.Size(182, 31);
            this.resFinalBalans.TabIndex = 3;
            this.resFinalBalans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resAmountPaid
            // 
            this.resAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resAmountPaid.Location = new System.Drawing.Point(112, 32);
            this.resAmountPaid.Name = "resAmountPaid";
            this.resAmountPaid.Size = new System.Drawing.Size(182, 31);
            this.resAmountPaid.TabIndex = 2;
            this.resAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalBalans
            // 
            this.lblFinalBalans.AutoSize = true;
            this.lblFinalBalans.Location = new System.Drawing.Point(17, 79);
            this.lblFinalBalans.Name = "lblFinalBalans";
            this.lblFinalBalans.Size = new System.Drawing.Size(96, 20);
            this.lblFinalBalans.TabIndex = 1;
            this.lblFinalBalans.Text = "Final Balance";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(17, 37);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(94, 20);
            this.lblAmountPaid.TabIndex = 0;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // BMRGroupBox
            // 
            this.BMRGroupBox.Controls.Add(this.btnBMR);
            this.BMRGroupBox.Controls.Add(this.listBoxBMRRes);
            this.BMRGroupBox.Controls.Add(this.ActivLevelGroupBox);
            this.BMRGroupBox.Controls.Add(this.txtAge);
            this.BMRGroupBox.Controls.Add(this.lblAge);
            this.BMRGroupBox.Controls.Add(this.GenderGroupBox);
            this.BMRGroupBox.Location = new System.Drawing.Point(23, 384);
            this.BMRGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BMRGroupBox.Name = "BMRGroupBox";
            this.BMRGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BMRGroupBox.Size = new System.Drawing.Size(1126, 291);
            this.BMRGroupBox.TabIndex = 7;
            this.BMRGroupBox.TabStop = false;
            this.BMRGroupBox.Text = "BMR Calculator";
            // 
            // btnBMR
            // 
            this.btnBMR.Location = new System.Drawing.Point(125, 236);
            this.btnBMR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(205, 31);
            this.btnBMR.TabIndex = 5;
            this.btnBMR.Text = "Calculate BMR";
            this.btnBMR.UseVisualStyleBackColor = true;
            this.btnBMR.Click += new System.EventHandler(this.btnBMR_Click);
            // 
            // listBoxBMRRes
            // 
            this.listBoxBMRRes.ForeColor = System.Drawing.Color.Green;
            this.listBoxBMRRes.FormattingEnabled = true;
            this.listBoxBMRRes.ItemHeight = 20;
            this.listBoxBMRRes.Location = new System.Drawing.Point(531, 29);
            this.listBoxBMRRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxBMRRes.Name = "listBoxBMRRes";
            this.listBoxBMRRes.Size = new System.Drawing.Size(577, 204);
            this.listBoxBMRRes.TabIndex = 4;
            // 
            // ActivLevelGroupBox
            // 
            this.ActivLevelGroupBox.Controls.Add(this.rbtnLevel5);
            this.ActivLevelGroupBox.Controls.Add(this.rbtnLevel4);
            this.ActivLevelGroupBox.Controls.Add(this.rbtnLevel3);
            this.ActivLevelGroupBox.Controls.Add(this.rbtnLevel2);
            this.ActivLevelGroupBox.Controls.Add(this.rbtnLevel1);
            this.ActivLevelGroupBox.Location = new System.Drawing.Point(224, 29);
            this.ActivLevelGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActivLevelGroupBox.Name = "ActivLevelGroupBox";
            this.ActivLevelGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActivLevelGroupBox.Size = new System.Drawing.Size(301, 199);
            this.ActivLevelGroupBox.TabIndex = 3;
            this.ActivLevelGroupBox.TabStop = false;
            this.ActivLevelGroupBox.Text = "Weekly activity level";
            // 
            // rbtnLevel5
            // 
            this.rbtnLevel5.AutoSize = true;
            this.rbtnLevel5.Location = new System.Drawing.Point(7, 165);
            this.rbtnLevel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnLevel5.Name = "rbtnLevel5";
            this.rbtnLevel5.Size = new System.Drawing.Size(257, 24);
            this.rbtnLevel5.TabIndex = 4;
            this.rbtnLevel5.TabStop = true;
            this.rbtnLevel5.Text = "Extra active (hard exercises or job)";
            this.rbtnLevel5.UseVisualStyleBackColor = true;
            // 
            // rbtnLevel4
            // 
            this.rbtnLevel4.AutoSize = true;
            this.rbtnLevel4.Location = new System.Drawing.Point(7, 129);
            this.rbtnLevel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnLevel4.Name = "rbtnLevel4";
            this.rbtnLevel4.Size = new System.Drawing.Size(193, 24);
            this.rbtnLevel4.TabIndex = 3;
            this.rbtnLevel4.TabStop = true;
            this.rbtnLevel4.Text = "Very active (6 to 7 times)";
            this.rbtnLevel4.UseVisualStyleBackColor = true;
            // 
            // rbtnLevel3
            // 
            this.rbtnLevel3.AutoSize = true;
            this.rbtnLevel3.Location = new System.Drawing.Point(7, 96);
            this.rbtnLevel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnLevel3.Name = "rbtnLevel3";
            this.rbtnLevel3.Size = new System.Drawing.Size(241, 24);
            this.rbtnLevel3.TabIndex = 2;
            this.rbtnLevel3.TabStop = true;
            this.rbtnLevel3.Text = "Moderately active (3 to 5 times)";
            this.rbtnLevel3.UseVisualStyleBackColor = true;
            // 
            // rbtnLevel2
            // 
            this.rbtnLevel2.AutoSize = true;
            this.rbtnLevel2.Location = new System.Drawing.Point(7, 63);
            this.rbtnLevel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnLevel2.Name = "rbtnLevel2";
            this.rbtnLevel2.Size = new System.Drawing.Size(209, 24);
            this.rbtnLevel2.TabIndex = 1;
            this.rbtnLevel2.TabStop = true;
            this.rbtnLevel2.Text = "Lightly active (1 to 3 times)";
            this.rbtnLevel2.UseVisualStyleBackColor = true;
            // 
            // rbtnLevel1
            // 
            this.rbtnLevel1.AutoSize = true;
            this.rbtnLevel1.Location = new System.Drawing.Point(7, 29);
            this.rbtnLevel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnLevel1.Name = "rbtnLevel1";
            this.rbtnLevel1.Size = new System.Drawing.Size(236, 24);
            this.rbtnLevel1.TabIndex = 0;
            this.rbtnLevel1.TabStop = true;
            this.rbtnLevel1.Text = "Sedentary (little or no exercise)";
            this.rbtnLevel1.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(73, 171);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(123, 27);
            this.txtAge.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(38, 175);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.rbtnFemale);
            this.GenderGroupBox.Controls.Add(this.rbtnMale);
            this.GenderGroupBox.Location = new System.Drawing.Point(17, 29);
            this.GenderGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenderGroupBox.Size = new System.Drawing.Size(200, 121);
            this.GenderGroupBox.TabIndex = 0;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(107, 51);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(78, 24);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(21, 51);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(63, 24);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 691);
            this.Controls.Add(this.BMRGroupBox);
            this.Controls.Add(this.FutureValGroupBox);
            this.Controls.Add(this.btnCalcSaving);
            this.Controls.Add(this.SavingPlanGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.UnitGroupBox);
            this.Controls.Add(this.BMICalcGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "Body Mass Index";
            this.BMICalcGroupBox.ResumeLayout(false);
            this.BMICalcGroupBox.PerformLayout();
            this.UnitGroupBox.ResumeLayout(false);
            this.UnitGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.SavingPlanGroupBox.ResumeLayout(false);
            this.SavingPlanGroupBox.PerformLayout();
            this.FutureValGroupBox.ResumeLayout(false);
            this.FutureValGroupBox.PerformLayout();
            this.BMRGroupBox.ResumeLayout(false);
            this.BMRGroupBox.PerformLayout();
            this.ActivLevelGroupBox.ResumeLayout(false);
            this.ActivLevelGroupBox.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox BMICalcGroupBox;
        private GroupBox UnitGroupBox;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtName;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblName;
        private RadioButton rbtnImperial;
        private RadioButton rbtnMetric;
        private Button btnCalc;
        private GroupBox ResultGroupBox;
        private Label lblWeightCateResult;
        private Label lblBMIResult;
        private Label lblWeightCate;
        private Label lblBMI;
        private Label Res;
        private GroupBox SavingPlanGroupBox;
        private TextBox txtMonDes;
        private Label lblPer;
        private Label lblMonDes;
        private TextBox txtPer;
        private Button btnCalcSaving;
        private GroupBox FutureValGroupBox;
        private Label resFinalBalans;
        private Label resAmountPaid;
        private Label lblFinalBalans;
        private Label lblAmountPaid;
        private TextBox txtFees;
        private TextBox txtGrowth;
        private Label lblFees;
        private Label lblGrowth;
        private Label resTotalFees;
        private Label resAmountEarned;
        private Label label3;
        private Label lblAmountEarned;
        private GroupBox BMRGroupBox;
        private GroupBox GenderGroupBox;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private GroupBox ActivLevelGroupBox;
        private RadioButton rbtnLevel5;
        private RadioButton rbtnLevel4;
        private RadioButton rbtnLevel3;
        private RadioButton rbtnLevel2;
        private RadioButton rbtnLevel1;
        private TextBox txtAge;
        private Label lblAge;
        private Button btnBMR;
        private ListBox listBoxBMRRes;
    }
}