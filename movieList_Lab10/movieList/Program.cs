using System;
using System.Collections.Generic;
using System.Linq;

namespace movieList
{
    class Program
    {
        //private static object movieList;
        private static string response;
        private static string catChoice;

        public static void Main(string[] args)
        {
            // req2
            List<Movie> MovieList = new List<Movie>();
            
            MovieList.Add(new Movie("Rugrats", "Animated"));
            MovieList.Add(new Movie("LionKing", "Animated"));
            MovieList.Add(new Movie("Toy Story", "Animated"));
            MovieList.Add(new Movie("Minions", "Animated"));
            MovieList.Add(new Movie("Fast & the Furious ", "Drama"));
            MovieList.Add(new Movie("White Chicks", "Comedy"));
            MovieList.Add(new Movie("House Party3", "Comedy"));
            MovieList.Add(new Movie("Wizard of OZ", "Drama"));
            MovieList.Add(new Movie("Willy Wonka", "Animated"));
            MovieList.Add(new Movie("Mortal Kombat", "Animated"));

            //foreach (var movie in MovieList)
            //{
            //    Console.WriteLine("Please  enter a movie by type of movie");
            //    Console.WriteLine("Movie: {0}", movie.GetTitle());
            //}
            do
            {
                // Ask user for their category choice. 
                Console.WriteLine("What Movie category are you interested in? \nAnimated \nDrama \nComedy");
                foreach (var movie in MovieList)
                {
                    if (movie.GetCategory() == catChoice)
                    {
                        Console.WriteLine("Movie: {0}", movie.GetTitle());
                    }
                }
                Console.WriteLine("Continue? y/n");
                response = Console.ReadLine();
            } while (response.ToLower() == "y");
            

        } 

            
       
    }
}