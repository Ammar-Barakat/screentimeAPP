namespace donotwatchAPP.Models.Details
{
    public class Crew
    {
        public int id { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }
        public string known_for_department { get; set; }
        public List<Job> jobs { get; set; }
        public string profile_path { get; set; }
    }

    public class Job
    {
        public string job { get; set; }
    }
}
