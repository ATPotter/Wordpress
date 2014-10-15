using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

using ServiceStack.ServiceClient.Web;

using WordpressDto;

namespace Wordpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // Create our JSON service client with base URL
            var site = ConfigurationManager.AppSettings["site"];
            var client = new JsonServiceClient(
                string.Format(CultureInfo.InvariantCulture,
                "https://public-api.wordpress.com/rest/v1/sites/{0}",
                site));

            // Now try to read back the site information
//            var siteInfo = client.Get<Site>("");

            // Get some information about the posts

            var postInfo = client.Get<Posts>("/posts");


            return;
        }
    }
}
