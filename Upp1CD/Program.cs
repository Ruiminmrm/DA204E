using System;

namespace Upp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Pet Owner";

            //create a pet object
            Pet petObj = new Pet();
            //call a method of the object to run
            petObj.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            //create a ticketseller object
            TicketSeller ticketObj = new TicketSeller();
            //call a method of the object to run
            ticketObj.start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            //create a album object
            Album albumObj = new Album();
            //call a method of the object to run
            albumObj.Start();

            Console.WriteLine("Enjoy listening!");
        }
    }
}
