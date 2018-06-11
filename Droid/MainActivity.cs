using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using SwitchMediaTest.Droid.Adapter;

namespace SwitchMediaTest.Droid
{
    [Activity(Label = "Movie")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            // Find views
            var pager = FindViewById<ViewPager>(Resource.Id.pager);
            var tabLayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            var adapter = new CustomPagerAdapter(this, SupportFragmentManager);
            var toolbar = FindViewById<Toolbar>(Resource.Id.my_toolbar);

            // Setup Toolbar
            SetSupportActionBar(toolbar);
            SupportActionBar.Hide();

            // Set adapter to view pager
            pager.Adapter = adapter;

            // Setup tablayout with view pager
            tabLayout.SetupWithViewPager(pager);

        }
    }
}
