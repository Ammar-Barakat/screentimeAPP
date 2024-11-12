namespace donotwatchAPP.Models.Details
{
    public class Details
    {
        public int id { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }
        public string tagline { get; set; }
        public string overview { get; set; }
        public int number_of_seasons { get; set; }
        public int number_of_episodes { get; set; }
        public string first_air_date { get; set; }
        public string last_air_date { get; set; }
        public string status { get; set; }
        public List<Genre> genres { get; set; }
        public string original_language { get; set; }
        public List<Season> seasons { get; set; }
        public Credits credits { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }
    }
}
