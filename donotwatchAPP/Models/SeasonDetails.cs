namespace donotwatchAPP.Models
{
    public class SeasonDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public int season_number { get; set; }
        public string overview { get; set; }
        public string air_date { get; set; }
        public List<EpisodeDetails> episodes { get; set; }
        public string poster_path { get; set; }
    }
}
