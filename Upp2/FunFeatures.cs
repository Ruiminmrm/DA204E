using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp2
{
    internal class FunFeatures
    {
        private string name = "";
        private string email = "";
        private void Introduce()
        {
            Console.WriteLine("My name is Ruimin and I'm a student of the Programming in C#! in P1");
            Console.WriteLine("Pls let me know about you!");

            ReadName();
            //email
            Console.Write("E-mail : ");
            this.email = Console.ReadLine();

            //print name & email
            Console.WriteLine("Hi! Here is your fullname and  eamil! \n" + this.name + ", " +this.email);

            //end
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
        }

        public void CalculateStrengthLength()
        {
            Console.WriteLine("Write a text and press Enter. I will then calculate the number of chars included in the text without space!");
           
            string st = Console.ReadLine();

            //replace space with "", so we have a length without length of space
            st = st.Replace(" ", "");
            int len = st.Length;
            Console.WriteLine("Number of chars : " + len);

            //end
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
        }

        public void PredictTheDay()
        {
            Console.Write("I'm a fortune teller. \n" + "Select a  number between 1 and 7 : ");
            string num;
            num = Console.ReadLine();
            switch (num)
            {
                case "1": 
                    Console.WriteLine("Monday: Keep calm my friend! You can fall apart!");
                    break;
                case "2": 
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case "3":
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case "4": 
                    Console.WriteLine("Thursday, OMG, still one day to Friday!");
                    break;
                case "5":
                    Console.WriteLine("It's Friday! You are in love!");
                    break;
                case "6": 
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case "7": 
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default :
                    Console.WriteLine("Not in a good mode? This is not a valid date!");
                    break;
            }
            //end
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
        }

        public void ReadName()
        {
            //first name
            string fname;
            Console.Write("First Name : ");
            fname = Console.ReadLine();

            //last name
            string lname;
            Console.Write("Last Name : ");
            lname = Console.ReadLine();

            //merge fname & lname
            this.name = fname + " " + lname;
        }
        private bool RunAgain()
        {
            bool done = false;
            Console.Write("Run again? (y/n)");

            // när input inte är "y" , stänga appen
            if (Console.ReadLine() != "y") 
                    done = true;
            Console.WriteLine("\n");
            return done;
        }
        public void Start()
        {
            Introduce(); //DONE
            bool done = false;
            do
            {
                PredictTheDay(); //DONE
                CalculateStrengthLength(); //DONE
                done = RunAgain(); //DONE
            } while (!done);
            Console.WriteLine("Welcome back !" + name);
        }
    }
}
