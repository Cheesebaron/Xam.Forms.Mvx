using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using CoolBeans.Services;

namespace CoolBeans.ViewModels
{
    public class MainViewModel 
        : MvxViewModel
    {
        private readonly IMovieService _service;

        public MainViewModel(IMovieService service)
        {
            _service = service;
        }

        private string _searchString;

        public string SearchString
        {
            get { return _searchString; }
            set 
            {
                _searchString = value;
                RaisePropertyChanged(() => SearchString);
            }
        }

        private List<Movie> _movies;

        public List<Movie> Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                RaisePropertyChanged(() => Movies);
            }
        }

        private Movie _selectedMovie;

        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                RaisePropertyChanged(() => SelectedMovie);

                ShowMovieCommand.Execute(null);
            }
        }

        public ICommand GetMoviesCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    Movies = await _service.GetMovieList(SearchString);
                });
            }
        }

        public ICommand ShowMovieCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<DetailedMovieViewModel>(new {movieId = SelectedMovie.id}),
                    () => SelectedMovie != null);
            }
        }
    }
}
