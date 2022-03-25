using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using FFImageLoading;

namespace MoviesApp
{
    [Activity(Label = "@string/app_name", Theme ="@style/AppTheme", MainLauncher =true)]
    public class MainActivity : AppCompatActivity
    {
        //List<Movie> mMovie;
        //List<Movie> mMovie;
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        MovieAdapter mAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            //ActionBar.Hide();
            //SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mRecyclerView.SetAdapter(mAdapter);

            //Plug in the linear layout manager:
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

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

            void OnItemClick(object sender, int position)
            {
                int MovieNum = position + 1;
                string MovieTitle = mMovie[position].Title;
                string MovieImg = mMovie[position].Image;
                string MovieDate = mMovie[position].Date;
                string Director = mMovie[position].Director;
                string ActorFirst = mMovie[position].Actors[0];
                string ScdActor = mMovie[position].Actors[1];
                string ThirdActor = mMovie[position].Actors[2];
                string FirstMovieName = mMovie[position].MovieName[0];
                string SecondMovieName = mMovie[position].MovieName[1];
                string ThirdMovieName = mMovie[position].MovieName[2];
                string FirstActorImage = mMovie[position].ActorsImage[0];
                string ScdActorImage = mMovie[position].ActorsImage[1];
                string ThirdActorImage = mMovie[position].ActorsImage[2];

                //Toast.MakeText(this, "Click!" + MovieNum, ToastLength.Short).Show();
                SetContentView(Resource.Layout.detailsMovie);
                TextView DetailsTitle = FindViewById<TextView>(Resource.Id.titleDetails);
                TextView DetailsDate = FindViewById<TextView>(Resource.Id.yearDetails);
                ImageView DetailsImg = FindViewById<ImageView>(Resource.Id.image);
                TextView DetailsDirector = FindViewById<TextView>(Resource.Id.directorDetails);
                TextView FirstActor = FindViewById<TextView>(Resource.Id.actorName);
                TextView ScdActorName = FindViewById<TextView>(Resource.Id.scdName);
                TextView ThirdActorName = FindViewById<TextView>(Resource.Id.thirdName);
                TextView FirstName = FindViewById<TextView>(Resource.Id.firstMovieName);
                TextView SecondName = FindViewById<TextView>(Resource.Id.secondMovieName);
                TextView ThirdName = FindViewById<TextView>(Resource.Id.thirdMovieName);
                ImageView FirstImage = FindViewById<ImageView>(Resource.Id.firstActorImg);
                ImageView ScdImage = FindViewById<ImageView>(Resource.Id.scdActorImg);
                ImageView ThirdImage = FindViewById<ImageView>(Resource.Id.thirdActorImg);

                DetailsTitle.Text = MovieTitle;
                DetailsDate.Text = MovieDate;
                DetailsDirector.Text = Director;
                FirstActor.Text = ActorFirst;
                ScdActorName.Text = ScdActor;
                ThirdActorName.Text = ThirdActor;
                FirstName.Text = FirstMovieName;
                SecondName.Text = SecondMovieName;
                ThirdName.Text = ThirdMovieName;

                GetImage(FirstActorImage.ToString(), FirstImage);
                GetImage(ScdActorImage.ToString(), ScdImage);
                GetImage(ThirdActorImage.ToString(), ThirdImage);
                GetImage(MovieImg.ToString(), DetailsImg);

            }
            void GetImage(string imageUrl, ImageView imageview)
            {
                ImageService.Instance.LoadUrl(imageUrl)
                    .Retry(3, 200)
                    .DownSample(400, 400)
                    .Into(imageview);
            }
            //Plug in my adapter:
            mAdapter = new MovieAdapter(mMovie);
            mRecyclerView.SetAdapter(mAdapter);
            mAdapter.ItemClick += OnItemClick;

        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home)
                this.OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }
    }
}
