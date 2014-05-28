using Cirrious.MvvmCross.ViewModels;

namespace CoolBeans.ViewModels
{
    public class MovieViewModel : MvxViewModel
    {
        public MovieViewModel(Movie model)
        {
            Model = model;

            Name = Model.title;
            CriticsScore = Model.ratings.critics_score;
            AudienceScore = Model.ratings.audience_score;
            ThumbnailUrl = Model.posters.thumbnail;
        }

        public Movie Model { get; private set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        private int _criticsScore;

        public int CriticsScore
        {
            get { return _criticsScore; }
            set
            {
                _criticsScore = value;
                RaisePropertyChanged(() => CriticsScore);
            }
        }

        private int _audienceScore;

        public int AudienceScore
        {
            get { return _audienceScore; }
            set
            {
                _audienceScore = value;
                RaisePropertyChanged(() => AudienceScore);
            }
        }

        private string _thumbnailUrl;

        public string ThumbnailUrl
        {
            get { return _thumbnailUrl; }
            set
            {
                _thumbnailUrl = value;
                RaisePropertyChanged(() => ThumbnailUrl);
            }
        }
    }
}
