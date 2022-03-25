using System;
using System.Collections.Generic;

namespace MoviesApp
{
    public class MovieService
    {

        public MovieService()
        {
            List<Movie> mMovie = new List<Movie>();
            Movie movie1 = new Movie("Euphoria", "2020", "https://tiny.pl/9n2gf", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie2 = new Movie("Games of thrones", "2011", "https://tiny.pl/9n2rg", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie3 = new Movie("Wolf from Wall Street", "2013", "https://fwcdn.pl/fpo/65/97/426597/7586610.3.jpg", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie4 = new Movie("Harry Potter", "2002", "https://tiny.pl/9n272", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie5 = new Movie("Inglourious Basterds", "2009", "https://tiny.pl/9n27n", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie6 = new Movie("Friends", "2009", "https://tiny.pl/9n27p", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie7 = new Movie("Emily in Paris", "2020", "https://tiny.pl/9n2g6", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie8 = new Movie("Batman", "2022", "https://fwcdn.pl/fpo/63/18/626318/7998475.3.jpg", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie9 = new Movie("Gone Girl", "2014", "https://fwcdn.pl/fpo/54/09/695409/7641076.3.jpg", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });
            Movie movie10 = new Movie("Fight Club", "1999", "https://image.ceneostatic.pl/data/products/45249114/i-fight-club.jpg", "Augustine Frizzell", new string[] { "Zendaya", "Hunter Schafer", "Angus Cloud" }, new string[] { "Rue", "Jules", "Fezco" }, new string[] { "https://tiny.pl/9n2jh", "https://tiny.pl/9n2jm", "https://tiny.pl/9n2pn" });

            mMovie.Add(movie1);
            mMovie.Add(movie2);
            mMovie.Add(movie3);
            mMovie.Add(movie4);
            mMovie.Add(movie5);
            mMovie.Add(movie6);
            mMovie.Add(movie7);
            mMovie.Add(movie8);
            mMovie.Add(movie9);
            mMovie.Add(movie10);


        }
    }
}
