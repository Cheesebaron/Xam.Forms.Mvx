using Cirrious.MvvmCross.ViewModels;
using CoolBeans.Services;

namespace CoolBeans.ViewModels
{
    public class DetailedMovieViewModel 
        : MvxViewModel
    {
        private int _movieId;
        private Movie _model;

        public void Init(int movieId)
        {
            _movieId = movieId;
        }

        public override async void Start()
        {
            base.Start();

            if (_model == null)
                _model = await _service.GetMovieFromId(_movieId);

            RaiseAllPropertiesChanged();
        }

        private readonly IMovieService _service;

        public DetailedMovieViewModel(IMovieService service)
        {
            _service = service;
        }

        public string Name
        {
            get { return _model.title; }
        }

        public string Synopsis
        {
            get { return _model.synopsis; }
        }

        public int CriticsScore
        {
            get { return _model.ratings.critics_score; }
        }

        public int AudienceScore
        {
            get { return _model.ratings.audience_score; }
        }

        public string ThumbnailUrl
        {
            get { return _model.posters.thumbnail; }
        }
    }
}
