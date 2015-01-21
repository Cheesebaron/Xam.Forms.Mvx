using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;


namespace CoolBeans.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            // TODO: Refactor: I don't like so much having this static field...
            var navigationPage = MvxFormsPhoneViewPresenter.NavigationPage;
            Content = navigationPage.ConvertPageToUIElement(this);
        }
    }
}
