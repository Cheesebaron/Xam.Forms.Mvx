using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsPhone.Platform;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Microsoft.Phone.Controls;

namespace CoolBeans.WinPhone
{
    public class Setup : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new CoolBeans.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxPhoneViewPresenter CreateViewPresenter(PhoneApplicationFrame rootFrame)
        {
            return new MvxFormsPhoneViewPresenter(rootFrame);
        }
    }
}