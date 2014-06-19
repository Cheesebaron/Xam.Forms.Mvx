using System.Threading.Tasks;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;
using MonoTouch.UIKit;
using Xamarin.Forms;

namespace CoolBeans.iOS
{
    public class MvxFormsTouchViewPresenter 
        : IMvxTouchViewPresenter
    {
        private readonly UIWindow _window;
        private NavigationPage _navigationPage;

        public MvxFormsTouchViewPresenter(UIWindow window)
        {
            _window = window;
        }

        public async void Show(MvxViewModelRequest request)
        {
            if (await TryShowPage(request))
                return;

            Mvx.Error("Skipping request for {0}", request.ViewModelType.Name);
        }

        private async Task<bool> TryShowPage(MvxViewModelRequest request)
        {
            var page = MvxPresenterHelpers.CreatePage(request);
            if (page == null)
                return false;

            var viewModel = MvxPresenterHelpers.LoadViewModel(request);

            if (_navigationPage == null)
            {
                Forms.Init();
                _navigationPage = new NavigationPage(page);
                _window.RootViewController = _navigationPage.CreateViewController();
            }
            else
            {
                await _navigationPage.PushAsync(page);
            }

            page.BindingContext = viewModel;
            return true;
        }

        public async void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is MvxClosePresentationHint)
            {
                // TODO - perhaps we should do more here... also async void is a boo boo
                await _navigationPage.PopAsync();
            }
        }

        public bool PresentModalViewController(UIViewController controller, bool animated)
        {
            return false;
        }

        public void NativeModalViewControllerDisappearedOnItsOwn()
        {
            
        }
    }
}