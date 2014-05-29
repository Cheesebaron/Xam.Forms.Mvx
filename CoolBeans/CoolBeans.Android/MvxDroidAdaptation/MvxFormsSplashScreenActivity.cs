using Cirrious.MvvmCross.Droid.Views;

namespace CoolBeans.Droid.MvxDroidAdaptation
{
    public abstract class MvxFormsSplashScreenActivity
        : MvxSplashScreenActivity
    {
        protected MvxFormsSplashScreenActivity()
        {
        }

        protected MvxFormsSplashScreenActivity(int resourceId)
            : base(resourceId)
        {
        }

        public override void InitializationComplete()
        {
            StartActivity(typeof(MvxNavigationActivity));
        }
    }
}