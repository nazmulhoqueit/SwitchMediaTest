using System;

using Android.App;
using Android.Runtime;
using SwitchMediaTest.Model;

namespace SwitchMediaTest.Droid
{

    [Application(Icon = "@mipmap/icon")]
    public class MyApplication : Application
    {
        public MyApplication(IntPtr handle, JniHandleOwnership transfer)
           : base(handle, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public Image[][] images { get; set; }
    }
}