using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordpressDto
{
    public class Author
    {
        public int ID { get; set; }
        public bool email { get; set; }
        public string name { get; set; }
        public string URL { get; set; }
        public string avatar_URL { get; set; }
        public string profile_URL { get; set; }
    }
}
