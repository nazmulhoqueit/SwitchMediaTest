using Android.Support.V4.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using SwitchMediaTest.Droid.Adapter;

namespace SwitchMediaTest.Droid.Fragments
{
    public class HomeFragment : Fragment
    {
        RecyclerView mRecycleView;
        RecyclerView.LayoutManager mLayoutManager;
        ImageViewAdapterHorizontal mAdapter;
       
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.home_layout, null);

            mRecycleView = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mLayoutManager = new LinearLayoutManager(Activity);
            mRecycleView.SetLayoutManager(mLayoutManager);
            mAdapter = new ImageViewAdapterHorizontal((Activity.Application as MyApplication).images, Activity);
            mRecycleView.SetAdapter(mAdapter);

            return view;

        }
    }
}
