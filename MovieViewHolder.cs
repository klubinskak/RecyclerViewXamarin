using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace MoviesApp
{
    public class MovieViewHolder : RecyclerView.ViewHolder
    {
        public TextView Title { get; set; }
        public TextView ReleaseDate { get; set; }
        public ImageView Image { get; set; }

        public MovieViewHolder (View itemView, Action<int> listener) : base(itemView)
        {

            Title = (TextView)itemView.FindViewById(Resource.Id.title);
            ReleaseDate = (TextView)itemView.FindViewById(Resource.Id.releaseDate);
            Image = itemView.FindViewById<ImageView>(Resource.Id.image);

            itemView.Click += (sender, e) => listener(base.LayoutPosition);

        }
    }
}
