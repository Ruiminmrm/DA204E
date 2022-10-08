using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp3
{
    class BMRCalculator
    {
        
        private int age;
        private double level;
        private double weight;
        private double height;
        public void SetHeight(double value)
        {
            height = value;
        }
        public void SetWeight(double value)
        {
            weight = value;
        }
        public void SetAge(int value)
        {
            age = value;
        }
        public void SetLevel(double value)
        {
            level = value;
        }
        //calculate calories for maintain weight 
        public double Maintain(double value)
        {
            return value * level;
        }
        //calculate bmr for different gender
        public double BMRFemale()
        {
            return BmrCalc() - 161;
        }
        public double BMRMale()
        {
            return BmrCalc() + 5;
        }
        //calculate bmr
        private double BmrCalc()
        {
            return  10 * weight + 6.25 * height - 5 * age;
        }
        
    }
}
