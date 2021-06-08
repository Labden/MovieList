using System;
using System.Collections.Generic;

namespace MovieObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("Welcome to the Movie List Application");

                Console.WriteLine();
                Console.WriteLine("There are 10 movies in this list.");

                string genreType = GetUserInput();
 
                List<Movie> Movies = new List<Movie>();

                Movies.Add(new Movie("Shrek", "Drama"));
                Movies.Add(new Movie("Pulp Fiction", "Action"));
                Movies.Add(new Movie("Fight Club", "Action"));
                Movies.Add(new Movie("Clockwork Orange", "SciFi"));
                Movies.Add(new Movie("Pineapple Express", "Comedy"));
                Movies.Add(new Movie("Star Wars", "SciFi"));
                Movies.Add(new Movie("Stepbrothers", "Comedy"));
                Movies.Add(new Movie("50 First Dates", "Romance"));
                Movies.Add(new Movie("Spaceballs", "Comedy"));
                Movies.Add(new Movie("The Notebook", "Romance"));
                //.count represents the last index
                for (int i = 0; i < Movies.Count; i++)
                {
                    Movie m = Movies[i];
                    if (m.Genre.ToUpper() == genreType)
                    {
                        Console.WriteLine(m.Name);
                    }

                }


                goOn = GetContinue();
            }
        }
        static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                return true;
            }
            else if (answer == "N")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                return GetContinue();

            }
        }
        public static string GetUserInput()
        {
            string result = "";
            bool goOn = true;
            while (goOn)
            {

                Console.WriteLine("What genre are you interested in? (SciFi, Drama, Action, Comedy or Romance)");
                string userInput = Console.ReadLine().Trim().ToUpper();

                if (userInput == "SCIFI" || userInput == "DRAMA" || userInput == "ACTION" || userInput == "COMEDY" || userInput == "ROMANCE")
                {
                    result = userInput;
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid genre");
                }
            }
            return result;
        }
    }
}