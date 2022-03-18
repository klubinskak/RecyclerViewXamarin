using System;
using System.Collections.Generic;

namespace MoviesApp
{
    public class Movie
    {
        public string title { get; set; }
        public string date { get; set; }
        public string image { get; set; }

        public Movie(string movieTitle, string date, string poster)
        {
            title = movieTitle;
            date = date;
            image = poster;


        }


    }


}
