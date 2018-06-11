using System;
using Android.Support.V7.Widget;  
using Android.Views;  
using Android.Widget;
using SwitchMediaTest.Droid.Common;
using SwitchMediaTest.Model;

namespace SwitchMediaTest.Droid.Adapter
{
    public class ImageViewAdapter : RecyclerView.Adapter
    {
        public event EventHandler<Image> ItemClick;
        public Image[] mPhotos;
        public ImageViewAdapter(Image[] photos)
        {
            mPhotos = photos;
        }
        public override int ItemCount
        {
            get { return mPhotos.Length; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ImageViewHolder vh = holder as ImageViewHolder;

            var bitmapImage = Utils.GetBitmapFromBytes(mPhotos[position].imageBytes);
            vh.Image.SetImageBitmap(bitmapImage);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.image_layout, parent, false);
            ImageViewHolder vh = new ImageViewHolder(itemView, OnClick, mPhotos);
            return vh;
        }

        private void OnClick(Image obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }
    }

    public class ImageViewHolder : RecyclerView.ViewHolder  
    {  
        public ImageView Image { get; set; }  
        public ImageViewHolder(View itemview, Action<Image> listener,Image[] mPhotos) : base(itemview)  
        {  
            Image = itemview.FindViewById<ImageView>(Resource.Id.imageView);
            itemview.Click += (sender, e) =>
            {
                listener(mPhotos[this.AdapterPosition]);
            };
        }  
    }  
}

