using System;
using System.Collections.Generic;
using System.Text;

namespace Upp1
{
    class Album
    {
        //create some variables 
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the Album Program! ");
            Console.WriteLine();

            //call the methods
            ReadAndSaveAlbumData();
            DisplayAlbumInfo();
        }
        public void ReadAndSaveAlbumData()
        {
            Console.WriteLine("What is the name of the your favorite music album? ");
            albumName = Console.ReadLine();

            Console.WriteLine("What is the name of the Artist or Band for " + this.albumName + "?");
            artistName = Console.ReadLine();

            Console.WriteLine("How many tracks does " + this.albumName + " have? ");
            //convert string to int
            numOfTracks = int.Parse(Console.ReadLine());
        }

        public void DisplayAlbumInfo()
        {
            Console.WriteLine("Album Name: " + this.albumName);
            Console.WriteLine("Artist Name: " + this.artistName);
            Console.WriteLine("Number of the Tracks: " + this.numOfTracks);
        }
    }
}
