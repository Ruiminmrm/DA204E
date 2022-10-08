using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Upp2
{
    internal class MathWork
    {
        private bool ExitCalculations()
        {
            bool runapp = true;
            Console.WriteLine("Exit Calculations? (y/n)");
            if (Console.ReadLine() == "y")
                runapp = false;
            return runapp;
        }

        private void PrintEventNumbers(int number1, int number2)
        {
            int even = number1;

            //two cases : if number1 is even(divide with 2 and have no rest) or number1(divide with 2 and ahve rest 1) is not even
            if(number1 % 2 == 0)
            {
                while(even <= number2)//even number can not larger than number2
                {
                    Console.Write(even + " ");
                    even = even + 2;
                }
            }
            else
            {
                even = even + 1; // the first even number in the domain
                while (even <= number2)
                {
                    Console.Write(even + " ");
                    even = even + 2;
                }
            }
        }

        public void PrintMultiplicationTable()
        {
            //initialise row & col
            int row = 0, col = 0;
            //the  outside loop is for row , from 1 to 12
            for (int i = 1; i < 13; i++)
            {
                row = i;
                //the inside loop is for col , from 1 to 12
                for (int j = 1; j < 13; j++)
                {
                    col = j;
                    Console.Write(string.Format("{0,4:d} ", row * col));
                }
                //wrap to the next line efter 12 output
                Console.WriteLine("");
            }
        }

        public void SumNumbers()
        {
                Console.WriteLine("Sum numbers between any two numbers");

                //start number 
                Console.Write("Give start number: ");
                int s = int.Parse(Console.ReadLine());

                //end number 
                Console.Write("Give end number: ");
                int e = int.Parse(Console.ReadLine());

                //change start to end if start > end
                int temp = 0;
                if (s > e)
                {
                    temp = s;
                    s = e;
                    e = temp;
                }
                Console.WriteLine("Sum between " + s + " and " + e + ": " + SumNumbers(s, e));

                //end SumNUmbers
                Console.WriteLine("");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("");

                //call method
                Console.WriteLine("Even numbers between " + s + " and " + e + ":");
                PrintEventNumbers(s, e);

                //end EventNumbers
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("");
        }

        private int SumNumbers(int start, int end)
        {
            //initialise sum
            int sum = 0;

            //use loop for calculation
            for(int i = start; i <= end; i++)
            {
                sum = sum + i;
            }   
            return sum;
        } 
        
        public void Start()
        {
            do
            {
                SumNumbers();
                Console.WriteLine("         ++++++++++Multiplication Table++++++++++");
                PrintMultiplicationTable();
            }while (ExitCalculations());
        }

    }
}
