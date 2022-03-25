using System;
using System.Collections.Generic;

namespace MoviesApp
{
    public class Movie
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public string Director { get; set; }
        public string[] Actors { get; set; }
        public string[] MovieName { get; set; }
        public string[] ActorsImage { get; set; }
        public EventHandler ClickHandler
        {
            get;
            set;
        }


        public Movie(string movieTitle, string date, string poster, string director, string[] actors, string[] movieName, string[] actorsImg)
        {
            Title = movieTitle;
            Date = date;
            Image = poster;
            Director = director;
            Actors = actors;
            MovieName = movieName;
            ActorsImage = actorsImg;
        }


    }
}
