using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using FFImageLoading;

namespace MoviesApp
{
    public class MovieAdapter : RecyclerView.Adapter
    {
        public List<Movie> mMovie;
        public event EventHandler<int> ItemClick;
        public MovieAdapter(List<Movie> data)
        {
            mMovie = data;
        }
        public override int ItemCount
        {
            get { return mMovie.Count; }
        }
        void OnClick (int position)
        {
            if (ItemClick != null)
                ItemClick(this, position);
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MovieViewHolder vh = holder as MovieViewHolder;

            vh.Title.Text = mMovie[position].Title;
            vh.ReleaseDate.Text = mMovie[position].Date;
            GetImage(mMovie[position].Image.ToString(), vh.Image);
            
        }
        //FFIMAGELOADING
        void GetImage(string imageUrl, ImageView imageview)
        {
            ImageService.Instance.LoadUrl(imageUrl)
                .Retry(3, 200)
                .DownSample(400, 400)
                .Into(imageview);
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.movieItem, parent, false);
            MovieViewHolder vh = new MovieViewHolder(itemView, OnClick);
            return vh;
        }
    }
}