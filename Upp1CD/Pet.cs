using System;
using System.Collections.Generic;
using System.Text;

namespace Upp1
{
    class Pet
    {
        //create variables
        private string name;
        private int age;
        private bool isFemale;
        
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from the Pet Owner application!");
            Console.WriteLine();

            //the methods
            ReadAndSavePetData();
            DisplayPetInfo();
        }

        public void ReadAndSavePetData()
        {
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine();

            Console.Write("What is " + name + "'s age? ");
            string textValue = Console.ReadLine();
            //convert string to int
            age = int.Parse(textValue);

            Console.Write("Is your pet a female (y/n)? ");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim();
            char response = strGender[0];

            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;
        }
        public void DisplayPetInfo()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Name: " + this.name + " Age: " + this.age);
            if (this.isFemale == true)
                Console.WriteLine(this.name + " is a good girl!");
            else
                Console.WriteLine(this.name + " is a good boy!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");


        }
    }
}
