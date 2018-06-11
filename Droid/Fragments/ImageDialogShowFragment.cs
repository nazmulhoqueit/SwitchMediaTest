
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using SwitchMediaTest.Droid.Common;
using SwitchMediaTest.Model;

namespace SwitchMediaTest.Droid.Fragments
{
    public class ImageDialogShowFragment : DialogFragment
    {
        private static Image mImage;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.imge_details_layout, container, false);
            var imageView = view.FindViewById<ImageView>(Resource.Id.imageFullView);
            var bitmapImage = Utils.GetBitmapFromBytes(mImage.imageBytes);
            imageView.SetImageBitmap(bitmapImage);

            var titleView = view.FindViewById<TextView>(Resource.Id.title);
            titleView.Text = mImage.sTitle;

            return view;

        }

        public static ImageDialogShowFragment NewInstance(Bundle buncle, Image image)
        {
            ImageDialogShowFragment fragment = new ImageDialogShowFragment();
            fragment.Arguments = buncle;
            mImage = image;
            return fragment;
        }
    }
}