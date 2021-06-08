using System;
using System.Collections.Generic;
using System.Text;

namespace MovieObjects
{
    class Movie
    {
        //This will track a few things: Name, Genre
        //We want to be to easily print all of the info on the movie from a single method call 

        //Class Recipe - each piece is totally optional, only make what you need
        //1) Properties/Variables 
        //2) Constructor(s) 
        //3) Regular Methods 

        public string Name { get; set; }
        public string Genre { get; set; }


        //By putting parameters into a constructor 
        //I am saying to other devs, this object must have these pieces of data
        public Movie(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} ");
            Console.WriteLine($"Genre: {Genre} ");
        }
    }
}
