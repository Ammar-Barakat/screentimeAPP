using System.Data;

namespace donotwatchAPP.Models.Details
{
    public class Cast
    {
        public int id { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }
        public string known_for_department { get; set; }
        public List<Role> roles { get; set; }
        public string profile_path { get; set; }
    }

    public class Role
    {
        public string character { get; set; }
    }
}
