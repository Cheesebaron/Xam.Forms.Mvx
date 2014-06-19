namespace CoolBeans
{
    internal class Constants
    {
        public const string RottenTomatoApiKey = "n5xybwfwgrnntrxpadvxvzvu";

        public const string RottenTomatoMovieListUrl =
            "http://api.rottentomatoes.com/api/public/v1.0/movies.json?apikey={0}&q={1}";

        public const string RottenTomatoMovieUrl =
            "http://api.rottentomatoes.com/api/public/v1.0/movies/{1}.json?apikey={0}";

        public const string TmdbApiKey = "c0d0458190688fc0796d41acf1cef8ec";

        public const string TmdbMovieSearchUrl = "http://api.themoviedb.org/3/search/multi?api_key={0}&query={1}";
    }
}
