using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoolBeans.WinPhone
{
    class MvxFormsPhoneViewPresenter : IMvxPhoneViewPresenter
    {
        public static NavigationPage NavigationPage;

        private PhoneApplicationFrame _rootFrame;

        public MvxFormsPhoneViewPresenter(PhoneApplicationFrame rootFrame)
        {
            _rootFrame = rootFrame;
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

            if (NavigationPage == null)
            {
                Forms.Init();
                NavigationPage = new NavigationPage(page);
                //_window.RootViewController = _navigationPage.CreateViewController();
                _rootFrame.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            else
            {
                await NavigationPage.PushAsync(page);
            }

            page.BindingContext = viewModel;
            return true;
        }

        public async void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is MvxClosePresentationHint)
            {
                // TODO - perhaps we should do more here... also async void is a boo boo
                await NavigationPage.PopAsync();
            }
        }
    }
}
