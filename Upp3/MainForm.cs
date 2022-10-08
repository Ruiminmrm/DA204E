namespace Upp3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private void InitializeGUI()
        {
            this.Text = "The body Mass Calculator";

            //input controls
            rbtnImperial.Checked = true;
            rbtnMale.Checked = true;
            rbtnLevel1.Checked = true;
            lblHeight.Text = "Height (inch)";
            lblWeight.Text = "Weight (lbs)";

            //output controls
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtMonDes.Text = string.Empty;
            txtPer.Text = string.Empty;
        }
        //Calculate BMI 
        private BMICalculator bmiCalc = new BMICalculator();    
        public Form()
        {
            InitializeComponent();
            InitializeGUI();// my initialization
        }
        //when user click btn Calculate BMI, do the following 
        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
                DisplayResults();// calculate anfd display result
        }
        private void DisplayResults()
        {
            //read name , height and weight before calculation
            ReadName();
            ReadHeight();
            ReadWeight();
            //calculate bmi and display results
            double bmi = bmiCalc.CalculateBMI();
            lblBMIResult.Text = bmi.ToString("f2");
            lblWeightCateResult.Text = bmiCalc.BmiWeightCategory().ToString();
            ResultGroupBox.Text = "Result for < " + bmiCalc.GetName() + " >";
            if (bmi > 40)
                Res.Text = "Overweight BMI is above 40. ";
            else if (bmi >= 35)
                Res.Text = "Overweight (Obesity class II) BMI is between 35 and 40.";
            else if (bmi >= 30)
                Res.Text = "Overweight (Obesity class I) BMI is between 30 and 45.";
            else if (bmi >= 25)
                Res.Text = "Overweight (Pre-obesity) BMI is between 25 and 30.";
            else if (bmi >= 18.5)
                Res.Text = "Normal weight BMI is between 18.5 and 25.";
            else
                Res.Text = "Underweight BMI is below 18.5.";
        }            
        //if rbtn button for different unit is checked, do following 
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                //change text and unit for calculation
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnImperial.Checked)
            {
                //change text and unit for calculation
                lblHeight.Text = "Height (inch)";
                lblWeight.Text = "Weight (lbs)";
                bmiCalc.SetUnit(UnitTypes.Imperial);
            }
        }
        private bool ReadHeight()
        {
            double outValue;
            // ok - true if textbox for height is a number 
            //    - false for else situations and display a messagebox with info
            bool ok = double.TryParse(txtHeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                    bmiCalc.SetHeight(outValue);
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid height value!", "Error");
            return ok;
        }
        private bool ReadInputBMI()
        {
            //use bool to check and read BMI(positive number) 
            bool ok = true;
            if (bmiCalc.CalculateBMI() <= 0)
                ok = false;
            return ok;
        }
        private void ReadName()
        {
            txtName.Text.Trim();
            //if textbox for name is empty - set defalut name as "Unknown"
            //                    is not empty - setName
            if (!string.IsNullOrEmpty(txtName.Text))
                bmiCalc.SetName(txtName.Text);
            else
                bmiCalc.Name = "Unknown";
        }
        private bool ReadWeight()
        {
            double outValue;
            // ok - true if textbox for weight is a number 
            //    - false for else situations and display a messagebox with info
            bool ok = double.TryParse(txtWeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                    bmiCalc.SetWeight(outValue);
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid weight value!", "Error");
            return ok;
        }

        //Calculate saving
        private SavingCalculator savCalc = new SavingCalculator();
        //when btn Calculate saving is clicked , do following 
        private void btnCalcSaving_Click(object sender, EventArgs e)
        {
            DisplayFutureVal();
        }
        private void DisplayFutureVal()
        {
            //read MonthDes, Period, Growth, Fees
            ReadMonDes();
            ReadPeriod();
            ReadGrowth();
            ReadFees();
            //display results
            resAmountPaid.Text = savCalc.AmountPaid().ToString("f2");
            resFinalBalans.Text = savCalc.FinalBalance().ToString("f2");
            resAmountEarned.Text = savCalc.AmountEarned().ToString("f2");
            resTotalFees.Text = savCalc.TotalFees().ToString("f2");
        }
        private bool ReadMonDes()
        {
            int value;
            // ok - true if textbox for MonthDes is a number 
            //    - false for else situations and display a messagebox with info
            bool ok = int.TryParse(txtMonDes.Text, out value);
            if (ok)
            {
                if (value > 0)
                    savCalc.SetMonDesposit(value);
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid desposit value!", "Error");
            return ok;
        }
        private bool ReadPeriod()
        {
            int value;
            // ok - true if textbox for period is a number 
            //    - false for else situations and display a messagebox with info
            bool ok = int.TryParse(txtPer.Text, out value);
            if (ok)
            {
                if (value > 0)
                    savCalc.SetTotalMonth(value);
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid period(years) value!", "Error");
            return ok;
        }
        private bool ReadGrowth()
        {
            double value;
            // ok - true if textbox for growth is a number 
            //    - false for else situations and display a messagebox with info
            bool ok = double.TryParse(txtGrowth.Text, out value); ;
            if (ok)
            {
                if (value > 0)
                    savCalc.SetGrowth(value);
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid Growth value in %!", "Error");
            return ok;
        }
        private bool ReadFees()
        {
            double value;
            // ok - true if textbox for fee is a number 
            //    - false for else situations and display a messagebox with info
            bool ok = double.TryParse(txtFees.Text, out value); ;
            if (ok)
            {
                if (value >= 0)
                    savCalc.SetFees(value);
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid Fees value in %!", "Error");
            return ok;
        }

        //Calculate BMR
        BMRCalculator bmrCalc = new BMRCalculator();
        //when user clicks the btn Calculate BMR , do following 
        private void btnBMR_Click(object sender, EventArgs e)
        {
            listBoxBMRRes.Items.Add("BMR RESULTS");
            listBoxBMRRes.Items.Add("");
            DisplayBMR();
        }
        private void DisplayBMR()
        {
            // read age, level, weight, height
            ReadAge();
            ReadLevel();
            ReadWeight();
            ReadHeight();
            // do calculation and display results 
            double bmr = bmrCalculate();
            double maintain = bmrCalc.Maintain(bmr);
            
            listBoxBMRRes.Items.Add("Your BMR (calories/day) :" + bmr.ToString("f1"));
            listBoxBMRRes.Items.Add("Calories to maintain your weight :" + maintain.ToString("f1"));
            listBoxBMRRes.Items.Add("Calories to lose 0,5kg per week : " + (maintain-500).ToString("f1"));
            listBoxBMRRes.Items.Add("Calories to lose  1 kg per week : " + (maintain - 1000).ToString("f1"));
            listBoxBMRRes.Items.Add("Calories to gain 0,5kg per week : " + (maintain + 500).ToString("f1"));
            listBoxBMRRes.Items.Add("Calories to gain  1 kg per week : " + (maintain + 1000).ToString("f1"));
            listBoxBMRRes.Items.Add("");
            listBoxBMRRes.Items.Add("----------Losing more than 1000 calories per day is to be avoided----------");
        }
        private bool ReadAge()
        {
            int value;
            // ok - true if textbox for age is a number 
            //    - false for else situations and display a messagebox with info
            bool ok = int.TryParse(txtAge.Text, out value);
            if (ok)
            {
                if (value > 0)
                    bmrCalc.SetAge(value);
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid Age value!", "Error");
            return ok;
        }
        private bool ReadLevel()
        {
            // set factor for different rbtnLevel.checked
            // initialize the bool to false(it will change to true direct because initialzationGUI)
            bool ok = false;
            if (rbtnLevel1.Checked)
            {
                ok = true;
                bmrCalc.SetLevel(1.2);
            }
            else if (rbtnLevel2.Checked)
            {
                ok = true;
                bmrCalc.SetLevel(1.375);
            }
            else if (rbtnLevel3.Checked)
            {
                ok = true;
                bmrCalc.SetLevel(1.550);
            }
            else if (rbtnLevel4.Checked)
            {
                ok = true;
                bmrCalc.SetLevel(1.725);
            }
            else if (rbtnLevel5.Checked)
            {
                ok = true;
                bmrCalc.SetLevel(1.9);
            }
            return ok;
        }
        private double bmrCalculate()
        {
            double bmr = 0 ; 
            // change unit to Metric and set values
            if (rbtnImperial.Checked)
            {
                double wkg = bmiCalc.GetWeight() * 0.45359237;
                bmrCalc.SetWeight(wkg);
                double hcm = bmiCalc.GetHeight() * 2.54;
                bmrCalc.SetHeight(hcm);
            }
            if (rbtnMetric.Checked)
            {
                bmrCalc.SetWeight(bmiCalc.GetWeight());
                bmrCalc.SetHeight(bmiCalc.GetHeight());
            }
            //calculate for different gender
            if (rbtnFemale.Checked)
            {
                bmr = bmrCalc.BMRFemale();
            }
            if (rbtnMale.Checked)
            {
                bmr = bmrCalc.BMRMale();
            }
            return bmr;
        }
    }
}