using Android.App;
using Android.Content.PM;
using CoolBeans.Droid.MvxDroidAdaptation;

namespace CoolBeans.Droid
{
    [Activity(
		Label = "Movies Xamarin.Forms"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, Theme = "@style/Theme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxFormsSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}