using System.Dynamic;

namespace WordpressDto
{
    public class Site
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string URL { get; set; }
        public bool jetpack { get; set; }
        public int post_count { get; set; }
        public int subscribers_count { get; set; }
        public string lang { get; set; }
        
        // ICON ???
        // LOGO ???

        public bool visible { get; set; }
        public bool is_private { get; set;  }
        public bool is_following { get; set; }
        public Meta meta { get; set; }


    }
}
