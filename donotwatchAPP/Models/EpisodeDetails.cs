namespace donotwatchAPP.Models
{
    public class EpisodeDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public int season_number { get; set; }
        public int episode_number { get; set; }
        public string overview { get; set; }
        public string air_date { get; set; }
        public int runtime { get; set; }
        public string still_path { get; set; }
    }
}
