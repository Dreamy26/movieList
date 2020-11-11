using System;
using System.Collections.Generic;

namespace movieList
{
    class Program
    {
        //private static object movieList;

        public static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();
            
                MovieList.Add(new Movie("Rugrats", "Animated"));
                MovieList.Add(new Movie("LionKing", "Animated"));
            MovieList.Add(new Movie("Toy Story", "animated"));
            MovieList.Add(new Movie("Minions", "Animated"));
            MovieList.Add(new Movie("Fast and the Furious ", "Drama"));
            MovieList.Add(new Movie("White Chicks", "Comedy"));
            MovieList.Add(new Movie("House Party3", "Comedy"));
            MovieList.Add(new Movie("Wizard of OZ", "Drama"));
            MovieList.Add(new Movie("Willy Wonka", "Animated"));
            MovieList.Add(new Movie("Mortal Kombat", "Animated"));

            foreach (var movie in MovieList)
            {
                Console.WriteLine("Movie: {0}", movie.GetTitle());
            }
            

        }
    }
}