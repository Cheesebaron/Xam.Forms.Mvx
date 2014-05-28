using Xamarin.Forms;

namespace CoolBeans.Pages
{
    public class MainPage 
        : ContentPage
    {
        private StackLayout _mainLayout;
        private StackLayout _searchLayout;
        private ListView _movieListView;
        private Entry _searchEntry;
        private Button _goButton;

        public MainPage()
        {
            Title = "Rotten Tomatoes Sample";

            _searchLayout = new StackLayout
            {
                Spacing = 10,
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            _searchLayout.Children.Add(_searchEntry = new Entry { Placeholder = "Movie Name" });
            _searchLayout.Children.Add(_goButton = new Button { Text = "Search", IsEnabled = true });

            Content = _mainLayout = new StackLayout
            {
                Padding = new Thickness(10),
                Spacing = 10,
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center
            };

            _mainLayout.Children.Add(_searchLayout);

            _movieListView = new ListView
            {
                ItemTemplate = new DataTemplate(typeof(ImageCell))
            };

            _mainLayout.Children.Add(_movieListView);

            _searchEntry.SetBinding(Entry.TextProperty, new Binding("SearchString"));
            _goButton.SetBinding(Button.CommandProperty, new Binding("GetMoviesCommand"));
            _movieListView.SetBinding(ListView.ItemsSourceProperty, new Binding("Movies"));
            _movieListView.SetBinding(ListView.SelectedItemProperty, new Binding("SelectedMovie"));
        }
    }
}
