using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
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

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            btnDone.Enabled = true;
            Application.DoEvents();
            browser1.Url = new Uri(
                string.Format(CultureInfo.InvariantCulture,
                "https://public-api.wordpress.com/oauth2/authorize?client_id={0}&redirect_uri={1}&response_type=code",
                tbClientID.Text, HttpUtility.UrlEncode(tbRedirectUri.Text)));
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
        //http://project365.thepotters.org/?code=K99chjTnwt&state
            var fullUri = browser1.Url.AbsoluteUri;

            try
            {
                // Gather the bit that we want
                var parts = fullUri.Split("=".ToCharArray());

                // Part 1 should have everything after the equals sign.  Now get everything before the first &
                var parts2 = parts[1].Split("&".ToCharArray());

                tbCode.Text = parts2[0];
            }
            catch (Exception)
            {
                tbCode.Text = "Unexpected reponse format: " + fullUri;
                throw;
            }
        }

        private void btnCompleteAuth_Click(object sender, EventArgs e)
        {
            // Build the HTTP Response - note this is POST data, not JSON
            var request = WebRequest.Create("https://public-api.wordpress.com/oauth2/token") as HttpWebRequest;
            request.Method = "POST";

            // Build the POST data
            var postData = string.Format(CultureInfo.InvariantCulture,
                "client_id={0}&redirect_uri={1}&client_secret={2}&code={3}&grant_type={4}",
                tbClientID.Text,
                HttpUtility.UrlEncode(tbRedirectUri.Text),
                tbClientSecret.Text,
                tbCode.Text,
                "authorization_code");

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            // We've built the message, now send it to Wordpress
            try
            {
                rtResponse.Clear();

                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream);
                var responseFromServer = reader.ReadToEnd();   // HttpUtility.UrlDecode(reader.ReadToEnd());

                // That gives us a message, which we can subsequently decode
                rtResponse.Text = responseFromServer;
            }
            catch (WebException ex)
            {
                using (WebResponse webResponse = ex.Response)
                {
                    using (var data = webResponse.GetResponseStream())
                    {
                        if (null != data)
                        {
                            using (var reader = new StreamReader(data))
                            {
                                rtResponse.Text = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }

            rtResponse.AppendText("Finished\r\n");
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string requestData = "{\"content\": \"This is a test\"}";

            // Build the HTTP Request
            var request = WebRequest.Create("https://public-api.wordpress.com/rest/v1/sites/76977328/posts/new") as HttpWebRequest;
            request.Method = "POST";
            request.Accept = "application/json";
            request.Headers["Authorization"] = "Bearer Q8KsA(vEvmDs&ZCO(HI%C0i@KYh%qiXSNtbBpl0hoAFIQwXIXfXkSrVxFaKD86v5";


            byte[] byteArray = Encoding.UTF8.GetBytes(requestData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Flush();
            dataStream.Close();

            // We've built the message, now send it to Wordpress
            try
            {
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream);
                var responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd());

                // That gives us a message, which we can subsequently decode
                rtResponse.Text = responseFromServer;
            }
            catch (WebException ex)
            {
                using (WebResponse webResponse = ex.Response)
                {
                    using (var data = webResponse.GetResponseStream())
                    {
                        if (null != data)
                        {
                            using (var reader = new StreamReader(data))
                            {
                                rtResponse.Text = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }

        }
    }
}
