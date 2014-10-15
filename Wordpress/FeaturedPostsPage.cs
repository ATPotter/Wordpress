using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServiceStack.ServiceClient.Web;
using WordpressDto;

namespace Wordpress
{
    public partial class FeaturedPostsPage : UserControl
    {
        private class Info
        {
            public int Index { get; set;}
            public string Name { get; set; }
            public string Owner { get; set; }
        }

        // Information we will need before we can run
        public string WpSite { get; set; }
        public string Authorization { get; set; }


        public FeaturedPostsPage()
        {
            InitializeComponent();

            WpSite = ConfigurationManager.AppSettings["site"];
            Authorization = "Q8KsA(vEvmDs&ZCO(HI%C0i@KYh%qiXSNtbBpl0hoAFIQwXIXfXkSrVxFaKD86v5";  //  ConfigurationManager.AppSettings["authorization"];
        }

        private void btnGetAllPosts_Click(object sender, EventArgs e)
        {
            var list = new List<Info>();

            // Okay, so we want to get a list of all posts
            var client = new JsonServiceClient(
                string.Format(CultureInfo.InvariantCulture,
                "https://public-api.wordpress.com/rest/v1/sites/{0}",
                WpSite));

            var postInfo = client.Get<Posts>("/posts?fields=found&number=1");
            lblNumEntries.Text = postInfo.found.ToString();


            return;
        }
    }
}
