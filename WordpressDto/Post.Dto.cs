using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WordpressDto
{
    public class Post
    {
        public int ID { get; set; }
        public int site_ID { get; set; }
        public Author author { get; set; }
        public DateTime date { get; set; }
        public DateTime modified{ get; set; }
        public string title { get; set; }
        public string URL { get; set; }
        public string short_URL { get; set; }
        public string content { get; set; }
        public string excerpt { get; set; }
        public string slug { get; set; }
        public string guid { get; set; }
        public string status { get; set; }
        public bool sticky { get; set; }
        public string password { get; set; }
        public object parent { get; set; }
        public string type { get; set; }
        public bool comments_open { get; set; }
        public bool pings_open { get; set; }
        public bool likes_enabled { get; set; }
        public bool sharing_enabled { get; set; }
        public int comment_count { get; set; }
        public bool like_count { get; set; }
        public bool i_like { get; set; }
        public bool is_reblogged { get; set; }
        public bool is_following { get; set; }
        public string global_ID { get; set; }
        public string featured_image { get; set; }
        public object post_thumbnail { get; set; }
        public string format { get; set; }
        public object geo { get; set; }
        public List<string> publicize_URLs { get; set; }
        public object tags { get; set; }
        public object categories { get; set; }
        public object attachments { get; set; }
        public List<MetadataRow> metadata { get; set; }
        public Meta meta { get; set; }
    }
}
