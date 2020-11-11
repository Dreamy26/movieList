//using System;
//using System.Collections.Generic;
//namespace movieList
//{
//    class Program
//    {
//        private static string response;
//        private static string catChoice;
       
//        public static void Main(string[] args)
//        {
//            // Initialize a list
//            List<Movie> MovieList = new List<Movie>();
//            // Add movies to the list
//            MovieList.Add(new Movie("Rugrats", "animated"));
//            MovieList.Add(new Movie("LionKing", "animated"));
//            MovieList.Add(new Movie("Another", "scifi"));
//            // Sort the list alphabetically so that our results will come back alphabetically
//            //Console.WriteLine(MovieList.Sort((x, y) => x.GetCategory().CompareTo(y.GetCategory())));
//            // Welcome the user
//            Console.WriteLine("Welcome to the Movie List Application!");
//            Console.WriteLine($"There are {MovieList.Count} movies in this list.");
//            do
//            {
//                Console.WriteLine("What category are you interested in?");
//                catChoice = Console.ReadLine();
//                foreach (var movie in MovieList)
//                {
//                    if (movie.GetCategory() == catChoice)
//                    {
//                        Console.WriteLine("Movie: {0}", movie.GetTitle());
//                    }
//                }
//                Console.WriteLine("Continue? y/n");
//                response = Console.ReadLine();
//            } while (response.ToLower() == "y");
//        }
//    }
//}


