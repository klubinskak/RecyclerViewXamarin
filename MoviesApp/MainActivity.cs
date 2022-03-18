using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;

namespace MoviesApp
{
    [Activity(Label = "@string/app_name", Theme ="@style/AppTheme", MainLauncher =true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        MovieAdapter mAdapter;
        Movie mMovie;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mRecyclerView.SetAdapter(mAdapter);



            //Plug in the linear layout manager:
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            
            List<Movie> mMovie = new List<Movie>();
            Movie movie1 = new Movie("Euphoria", "2020", "https://images.fanart.tv/fanart/euphoria-2019-5ec8c62aa702d.jpg");
            Movie movie2 = new Movie("Games of thrones", "2011", "https://upload.wikimedia.org/wikipedia/en/d/d8/Game_of_Thrones_title_card.jpg");
            Movie movie3 = new Movie("Wolf from Wall Street", "2013", "https://fwcdn.pl/fpo/65/97/426597/7586610.3.jpg");
            Movie movie4 = new Movie("Harry Potter", "2002", "https://www.purepc.pl/image/news/2021/01/25_harry_potter_od_hbo_max_warner_bros_szykuje_aktorski_serial_w_czarodziejskim_swiecie_na_premiere_jeszcze_poczekamy_0_b.jpg");
            Movie movie5 = new Movie("Inglourious Basterds", "2009", "https://m.media-amazon.com/images/M/MV5BOTJiNDEzOWYtMTVjOC00ZjlmLWE0NGMtZmE1OWVmZDQ2OWJhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_FMjpg_UX1000_.jpg");
            Movie movie6 = new Movie("Friends", "2009", "https://news.newonnetflix.info/wp-content/uploads/2017/09/friends.jpg");
            Movie movie7 = new Movie("Emily in Paris", "2020", "data:image/jpeg;base64,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");
            Movie movie8 = new Movie("Batman", "2022", "https://fwcdn.pl/fpo/63/18/626318/7998475.3.jpg");
            Movie movie9 = new Movie("Gone Girl", "2014", "https://fwcdn.pl/fpo/54/09/695409/7641076.3.jpg");
            Movie movie10 = new Movie("Fight Club", "1999", "https://image.ceneostatic.pl/data/products/45249114/i-fight-club.jpg");

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



            //Plug in my adapter:
            mAdapter = new MovieAdapter(mMovie);
            mRecyclerView.SetAdapter(mAdapter);

   

        }


    }
}
