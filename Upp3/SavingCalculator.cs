using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp3
{
     class SavingCalculator
    {
        
        private int monDesposit;
        private int totalMonth;
        private double amountPaid;  
        private double growthInProcent;
        private double feeInProcent;
        private double amountEarned;
        
        public void SetGrowth(double value)
        {
            growthInProcent = value / 1200;
        }
        public void SetMonDesposit(int value)
        {
            monDesposit = value;
        }
        public void SetTotalMonth(int years)
        {
            totalMonth = years * 12;
        }
        public void SetFees(double value)
        {
            feeInProcent = value / 100;
        }
        //calculate amount paid
        public double AmountPaid()
        {
            amountPaid = Convert.ToDouble(totalMonth * monDesposit);
            return amountPaid;
        }
        //calculate final balance(use for-loop)
        public double FinalBalance()
        {
            double balance = 0.0;
            for(int i = 1; i <= totalMonth; i++)
            {
                double interestEarned = growthInProcent * balance;
                balance += interestEarned + monDesposit;
            }
            return balance;
        }
        //calculate Amount earned
        public double AmountEarned()
        {
            double balance = FinalBalance();
            amountEarned = balance - amountPaid - feeInProcent * balance;
            return amountEarned;
        }
        //calculate total fees
        public double TotalFees()
        {
            double fees = feeInProcent * FinalBalance();
            return fees;
        }
    }
}
