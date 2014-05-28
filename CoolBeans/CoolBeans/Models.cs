using System.Collections.Generic;

namespace CoolBeans
{
    public class Links
    {
        public string self { get; set; }
    }

    public class AbridgedCast
    {
        public List<string> characters { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }

    public class AlternateIds
    {
        public string imdb { get; set; }
    }

    public class Links2
    {
        public string alternate { get; set; }
        public string cast { get; set; }
        public string clips { get; set; }
        public string reviews { get; set; }
        public string self { get; set; }
        public string similar { get; set; }
    }

    public class Posters
    {
        public string detailed { get; set; }
        public string original { get; set; }
        public string profile { get; set; }
        public string thumbnail { get; set; }
    }

    public class Ratings
    {
        public string audience_rating { get; set; }
        public int audience_score { get; set; }
        public int critics_score { get; set; }
        public string critics_rating { get; set; }
    }

    public class ReleaseDates
    {
        public string dvd { get; set; }
        public string theater { get; set; }
    }

    public class Movie
    {
        public List<AbridgedCast> abridged_cast { get; set; }
        public AlternateIds alternate_ids { get; set; }
        public string id { get; set; }
        public Links2 links { get; set; }
        public string mpaa_rating { get; set; }
        public Posters posters { get; set; }
        public Ratings ratings { get; set; }
        public ReleaseDates release_dates { get; set; }
        public object runtime { get; set; }
        public string synopsis { get; set; }
        public string title { get; set; }
        public int year { get; set; }
    }

    public class RootObject
    {
        public string link_template { get; set; }
        public Links links { get; set; }
        public List<Movie> movies { get; set; }
        public int total { get; set; }
    }
}
