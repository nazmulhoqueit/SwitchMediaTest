﻿using Android.Support.V4.App;
using Android.OS;
using Android.Views;

namespace SwitchMediaTest.Droid.Fragments
{
    public class LiveTvFragment : Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.blank_layout, null);
        }
    }
}
