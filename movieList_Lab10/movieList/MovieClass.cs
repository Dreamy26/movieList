using System;
namespace movieList
{
    internal class Movie
    {
        private string Title;
        private string Category;
       
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;

        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetCategory()
        {
            return Category;
        }

    }
}


