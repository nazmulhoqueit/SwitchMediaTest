using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using SwitchMediaTest.Droid.Fragments;
using SwitchMediaTest.Model;

namespace SwitchMediaTest.Droid.Adapter
{
    public class ImageViewAdapterHorizontal : RecyclerView.Adapter
    {
        public Image[][] mPhotos;
        private Activity mContext;
        const string DIALOG_TAG = "dialog";
        public ImageViewAdapterHorizontal(Image[][] photos, Activity context)
        {
            mPhotos = photos;
            mContext = context;
        }
        public override int ItemCount
        {
            get { return mPhotos.Length; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder vh = holder as RecyclerViewHolder;
            var mAdapter = new ImageViewAdapter(mPhotos[position]);
            mAdapter.ItemClick += mAdapter_ItemClick;
            vh.RecyclerViewHorizontal.SetAdapter(mAdapter);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.image_horizontal_layout, parent, false);
            RecyclerViewHolder vh = new RecyclerViewHolder(itemView, parent);
            return vh;
        }

        private void mAdapter_ItemClick(object sender, Image e)
        {
            //Toast.MakeText(mContext, "Title: " + e.sTitle, ToastLength.Short).Show();  

            FragmentTransaction ft = mContext.FragmentManager.BeginTransaction();
            Fragment prev = mContext.FragmentManager.FindFragmentByTag(DIALOG_TAG);
            if (prev != null)
                ft.Remove(prev);
            
            ft.AddToBackStack(null);

            //Create and hsow the dialog
            ImageDialogShowFragment frag = ImageDialogShowFragment.NewInstance(null, e);

            //Add fragment
            frag.Show(ft, DIALOG_TAG);
        }
}

    public class RecyclerViewHolder : RecyclerView.ViewHolder  
    {  
        public RecyclerView RecyclerViewHorizontal { get; set; }  
        public RecyclerViewHolder(View itemview, ViewGroup parent) : base(itemview)  
        {  
            RecyclerViewHorizontal = itemview.FindViewById<RecyclerView>(Resource.Id.recyclerViewHorizontal);  
            LinearLayoutManager horizontalLayoutManagaer = new LinearLayoutManager(parent.Context, LinearLayoutManager.Horizontal, false);
            RecyclerViewHorizontal.SetLayoutManager(horizontalLayoutManagaer);
        } 
    }  
}

