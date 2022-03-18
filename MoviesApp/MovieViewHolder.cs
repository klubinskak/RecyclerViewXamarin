using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace MoviesApp
{
    public class MovieViewHolder : RecyclerView.ViewHolder
    {
        public TextView Title { get; set; }
        public TextView Release_date { get; set; }
        public ImageView Image { get; set; }

        public MovieViewHolder (View itemView) : base(itemView)
        {

            Title = (TextView)itemView.FindViewById(Resource.Id.title);
            Release_date = (TextView)itemView.FindViewById(Resource.Id.releaseDate);
            Image = itemView.FindViewById<ImageView>(Resource.Id.image);


        }



    }
}
