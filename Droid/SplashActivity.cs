using System.Threading.Tasks;
using Android.App;
using Android.OS;
using SwitchMediaTest.ViewModels;

namespace SwitchMediaTest.Droid
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            await GetImages();
            StartActivity(typeof(MainActivity));
        }

        async private Task<bool> GetImages()
        {
            var viewModel = new HomeViewModel();
            (Application as MyApplication).images = await viewModel.GetImages();
            return true;
        }
    }
}