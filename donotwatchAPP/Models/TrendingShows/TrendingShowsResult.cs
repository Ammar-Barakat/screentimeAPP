namespace donotwatchAPP.Models.TrendingShows
{
    public class TrendingShowsResult
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public List<TrendingShow> results { get; set; }
    }
}
