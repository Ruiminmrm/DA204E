using System;
using System.Collections.Generic;
using System.Text;

namespace Upp1
{
    class TicketSeller
    {
        //create variables 
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public void start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children get always a 75% discount!");
            Console.WriteLine();

            //call  methods
            ReadAndSaveTicketData();
            DisplayTicketInfo();
        }

        public void ReadAndSaveTicketData()
        {
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();

            Console.WriteLine("Number of adult:");
            numOfAdults = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of children:");
            numOfChildren = int.Parse(Console.ReadLine());

            //caculate the amount to pay 
            this.amountToPay = this.numOfAdults * this.price + this.numOfChildren * this.price * 0.75;
        }

        public void DisplayTicketInfo()
        {
            Console.WriteLine(" +++ Your receipt +++ ");
            Console.WriteLine(" +++ Amount to pay = " + this.amountToPay);
            Console.WriteLine();
            Console.WriteLine(" +++ Thank you " + this.name + " and please come back! +++");
        }
    }
}
