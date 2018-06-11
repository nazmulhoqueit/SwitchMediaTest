
using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.App;
using Java.Lang;
using SwitchMediaTest.Droid.Fragments;

namespace SwitchMediaTest.Droid.Adapter
{
    public class CustomPagerAdapter : FragmentPagerAdapter
    {
        const int PAGE_COUNT = 3;
        private string[] tabTitles = new string[3];
        readonly Context context;

        public CustomPagerAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public CustomPagerAdapter(Context context, FragmentManager fm) : base(fm)
        {
            this.context = context;
            tabTitles[0] = context.Resources.GetString(Resource.String.home);
            tabTitles[1] = context.GetString(Resource.String.live_tv);
            tabTitles[2] = context.GetString(Resource.String.any_time);
        }

        public override int Count
        {
            get { return PAGE_COUNT; }
        }

        public override Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0:
                    HomeFragment tab1 = new HomeFragment();
                    return tab1;
                case 1:
                    LiveTvFragment tab2 = new LiveTvFragment();
                    return tab2;
                case 2:
                    AnytimeFragment tab3 = new AnytimeFragment();
                    return tab3;
                default:
                    return null;
            }
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return CharSequence.ArrayFromStringArray(tabTitles)[position];
        }
    }
}
