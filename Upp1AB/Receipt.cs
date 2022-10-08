using System;
using System.Collections.Generic;
using System.Text;

namespace Upp1High
{
    /*Create a cashier system.
      It should show  cashier how much to pay back
     */ 
    
    class Receipt
    {
        private int totalt;
        private double price;
        private double back;
        private int backInteger;
        private int amount;
        public void cases()
        {
            //show the date
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine();

            //the price that customer should pay
            Console.WriteLine("What is the price ?");
            price = double.Parse(Console.ReadLine());

            //the amount cashier get
            Console.WriteLine("How much does the cashier get ?");
            totalt = int.Parse(Console.ReadLine());

            //how much should pay back in integer
            back = totalt - price;
            backInteger = (int)Math.Floor(back);

            if (this.backInteger < 0)//if it is not enough
                Console.WriteLine("Customer should pay " + this.backInteger * (-1) + " kr more.");
            else if (this.backInteger == 0)//if it is enough
                Console.WriteLine("It is enough.");
            else//if cashier need to pay back
            {
                Console.WriteLine("Cashier should return " + this.backInteger + " kr.");
                Console.WriteLine();

                //call the method with three variables 
                PayBack(this.backInteger, 500, "500kr banknotes");
                PayBack(this.backInteger, 200, "200kr banknotes");
                PayBack(this.backInteger, 100, "100kr banknotes");
                PayBack(this.backInteger, 50, "50kr banknotes");
                PayBack(this.backInteger, 20, "20kr banknotes");
                PayBack(this.backInteger, 10, "10kr coins");
                PayBack(this.backInteger, 5, "5kr coins");
                PayBack(this.backInteger, 1, "1kr coins");
            }
            Console.WriteLine();
            Console.WriteLine("+++ Have a good day! +++");
        }
        public void PayBack(int bak, int val, string money)
        {
            while (bak >= val)
            {
                //amount of coins or banknotes
                amount = bak / val;
                bak = bak % val;
                Console.WriteLine(this.amount + "st " + money);
            }
            this.backInteger = this.backInteger % val;
        }
    }
}
