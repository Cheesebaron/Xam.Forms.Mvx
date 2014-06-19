using Xamarin.Forms;

namespace CoolBeans.Droid.MvxDroidAdaptation
{
    public interface IMvxPageNavigationHost
    {
        IMvxPageNavigationProvider NavigationProvider { get; set; }
    }

    public interface IMvxPageNavigationProvider
    {
        void Push(Page page);
        void Pop();
    }
}