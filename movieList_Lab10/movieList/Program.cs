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
            
                MovieList.Add(new Movie("Rugrats", "animated"));
                MovieList.Add(new Movie("LionKing", "animated"));

            foreach (var movie in MovieList)
            {
                Console.WriteLine("Movie: {0}", movie.GetTitle());
            }
            

        }
    }
}