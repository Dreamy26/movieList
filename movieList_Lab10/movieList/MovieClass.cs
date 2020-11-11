using System;
namespace movieList
{


    internal class Movie
    {
        // req3
        // we have two parameters
        private string Title;
        private string Category;

        // constructor includes method name and parameter list
        // constructor is a method whos name is the same as the name of its type, below that is "Movie"
        // req4 
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;

        }

        // implementation
        public string GetTitle()
        {
            return Title;
        }

        public string GetCategory()
        {
            return Category;
        }

        internal static object Distinct()
        {
            throw new NotImplementedException();
        }
    }

}





