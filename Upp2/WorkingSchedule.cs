using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp2
{
    internal class WorkingSchedule
    {
        // create a const variable
        const int weeksAYear = 52;
        private void ShowTableWeekend()
        {
            int num = 1;
            /* 
             * row * col
             * row is 4 (inside loop)
             * col is weeks of one year divided with 4 (outside loop)
             * Beacuse it should be 2 between week numbers. So i use i = i + 2 to decrease loop run times
             * num here is the week number and it is lees than total weeks of one year
             */
            for (int i = 1; i <= weeksAYear/4; i = i + 2)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (num > 52)
                        break;
                    Console.Write("Week " + num + "   ");
                    num = num + 2;
                }   
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------");
        }
        private void ShowTableNight()
        {
            int num = 1;
            //same as above. I just change the number from 2 to 3
            for (int i = 1; i <= weeksAYear / 4; i = i + 3)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (num > 52)
                        break;
                    Console.Write("Week " + num + "   ");
                    num = num + 3;
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------");
        }
        private void ShowMenu()
        {
            Console.WriteLine("---------------MAIN MENU---------------");
            Console.WriteLine("Show a list of the weekends to work : 1");
            Console.WriteLine("Show a list of the nights to work   : 2");
            Console.WriteLine("Exit the program                    : 0");
            Console.WriteLine("---------------------------------------");
            Console.Write("Your choice : ");
        }
        public void Start()
        {
            int choice;
            do
            {
                ShowMenu();
                /*Readline is for string.
                 * i use booleam method TryParse to try to convert string to int 
                 * if the string can't convert to int , it will exit the programm
                 * otherwise it continues to the switch part
                 */
                bool IsNum = int.TryParse(Console.ReadLine(), out choice);
                //use switch
                switch (choice)
                {
                    case 1:
                        ShowTableWeekend();
                        break;
                    case 2:
                        ShowTableNight();
                        break;
                    case 0:
                        break;
                    //use default to prevent special cases
                    default:
                        Console.WriteLine("Give a choice 1,2 or 0. ");
                        break;
                }
            } while (choice != 0);

        }
    }
}
