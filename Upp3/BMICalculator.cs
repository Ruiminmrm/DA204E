using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Upp3
{
    class BMICalculator
    {
        private string name = "No Name";
        private double height = 0;// inch or cm
        private double weight = 0;// kg or lbs
        private UnitTypes unit;

        public string Name { get; set; }

        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
        }
        public void SetHeight(double value)
        {
            if (value >= 0)
                height = value;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetWeight(double value)
        {
            if (value >= 0)
                weight = value;
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetUnit(UnitTypes value)
        {
            if (value == UnitTypes.Imperial || value == UnitTypes.Metric)
                unit = value;
        }
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            //initialize stringout as empty
            string stringout = string.Empty;
            //different stringout for different bmi
            if (bmi > 40)
                stringout = "Overweight (Obesity class III)";
            else if (bmi >= 35)
                stringout = "Overweight (Obesity class II)";
            else if (bmi >= 30)
                stringout = "Overweight (Obesity class I)";
            else if (bmi >= 25)
                stringout = "Overweight (Pre-obesity)";
            else if (bmi >= 18.5)
                stringout = "Normal weight";
            else
                stringout = "Underweight";
            return stringout;
        }
        public double CalculateBMI()
        {
            double bmi = 0;
            //calculate bmi for different unit
            if (unit == UnitTypes.Metric)
                bmi = weight / Math.Pow(height/100, 2);
            if (unit == UnitTypes.Imperial)
                bmi = 703.0 * weight / Math.Pow(height, 2);
            return bmi;
        }
    }
}
