using System;
namespace Upp1High
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("+++++++++++++++++++++++++++++");
                Console.WriteLine("+++ Welcome to the Store! +++");
                // create object
                Receipt receiptObj = new Receipt();
                // call the methods
                receiptObj.cases();
            }
        }
    }
}
