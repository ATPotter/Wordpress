using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Wordpress.OAuthHandlers
{
    public partial class FlickrOauth2 : UserControl
    {
        public FlickrOauth2()
        {
            InitializeComponent();
        }

        private void btnRequestToken_Click(object sender, EventArgs e)
        {
            var numSeconds = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds);

            const string requestString = @"https://www.flickr.com/services/oauth/request_token";

            // create the parameter string in alphabetical order
            var parameters = "oauth_callback=" + UrlHelper.Encode("http://www.thepotters.org");
            parameters += "&oauth_consumer_key=" + tbClientId.Text;
            parameters += "&oauth_nonce=" + "2340987";
            parameters += "&oauth_signature_method=HMAC-SHA1";
            parameters += "&oauth_timestamp=" + numSeconds;
            parameters += "&oauth_version=1.0";

            // Now build the full URL
            var url = requestString + "?"
                + parameters + "&oauth_signature="
                + generateSignature("GET", requestString, parameters, tbClientSecret.Text, string.Empty);

            // Ask Flickr to give us the Token and the Token secret
            var flickrResponse = new WebClient().DownloadString(url);

            // Now we want to extract the relevant information
            var split = flickrResponse.Split("&".ToCharArray());

            var okay = false;
            foreach (var s in split)
            {
                var newSplit = s.Split("=".ToCharArray());

                switch (newSplit[0])
                {
                    case "oauth_callback_confirmed":
                        okay = bool.Parse(newSplit[1]);
                        break;

                    case "oauth_token":
                        lblRequestToken.Text = newSplit[1];
                        break;

                    case "oauth_token_secret":
                        lblRequestTokenSecret.Text = newSplit[1];
                        break;
                }
            }

            // And we're done.
            return;
        }




        #region Helper Functions
        private static string generateSignature(
            string httpMethod,
            string ApiEndpoint,
            string parameters,
            string secret,
            string request_token)
        {
            //url encode the API endpoint and the parameters 

            //IMPORTANT NOTE:
            //encoded text should contain uppercase characters: '=' => %3D !!! (not %3d )
            //the HtmlUtility.UrlEncode creates lowercase encoded tags!
            //Here I use a urlencode class by Ian Hopkins
            string encodedUrl = UrlHelper.Encode(ApiEndpoint);
            string encodedParameters = UrlHelper.Encode(parameters);

            //generate the basestring
            string basestring = httpMethod + "&" + encodedUrl + "&";
            parameters = UrlHelper.Encode(parameters);
            basestring = basestring + parameters;

            //hmac-sha1 encryption:

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            //create key (request_token can be an empty string)
            string key = secret + "&" + request_token;
            byte[] keyByte = encoding.GetBytes(key);

            //create message to encrypt
            byte[] messageBytes = encoding.GetBytes(basestring);

            //encrypt message using hmac-sha1 with the provided key
            HMACSHA1 hmacsha1 = new HMACSHA1(keyByte);
            byte[] hashmessage = hmacsha1.ComputeHash(messageBytes);

            //signature is the base64 format for the genarated hmac-sha1 hash
            string signature = System.Convert.ToBase64String(hashmessage);

            //encode the signature to make it url safe and return the encoded url
            return UrlHelper.Encode(signature);

        }
        #endregion Helper Functions

        private void btnUserAuthorisation_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("https://www.flickr.com/services/oauth/authorize"
                          + "?oauth_token="
                          + lblRequestToken.Text
                          + "&perms=write");

        }

        private void btnGetUrl_Click(object sender, EventArgs e)
        {
            var url = browser.Url.ToString();
            Debug.WriteLine(url);

            // Get the token and the verifier
            // Now we want to extract the relevant information
            var split = url.Split("&".ToCharArray());

            foreach (var s in split)
            {
                var newSplit = s.Split("=".ToCharArray());

                if (newSplit.Length> 0)
                {
                    switch (newSplit[0])
                    {
                        case "oauth_verifier":
                            lblVerifier.Text = newSplit[1];
                            break;
                    }
                }
            }
        }

        private void btnGetAccessToken_Click(object sender, EventArgs e)
        {
            var numSeconds = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds);

            const string requestString = @"https://www.flickr.com/services/oauth/access_token";

            // create the parameter string in alphabetical order
            var parameters = "";
            parameters += "oauth_consumer_key=" + tbClientId.Text;
            parameters += "&oauth_nonce=" + "2340987";
            parameters += "&oauth_signature_method=HMAC-SHA1";
            parameters += "&oauth_timestamp=" + numSeconds;
            parameters += "&oauth_token=" + lblRequestToken.Text;
            parameters += "&oauth_verifier=" + lblVerifier.Text;
            parameters += "&oauth_version=1.0";

            // Now build the full URL
            var url = requestString + "?"
                + parameters + "&oauth_signature="
                + generateSignature("GET", requestString, parameters, tbClientSecret.Text, lblRequestTokenSecret.Text);

            // Ask Flickr to give us the Token and the Token secret
            var flickrResponse = new WebClient().DownloadString(url);

            // And split it up into its componenets
            var split = flickrResponse.Split("&".ToCharArray());

            foreach (var s in split)
            {
                var newSplit = s.Split("=".ToCharArray());
                if(2 == newSplit.Length)
                {
                    switch (newSplit[0])
                    {
                        case "fullname":
                            lblName.Text = newSplit[1];
                            break;

                        case "oauth_token":
                            lblAuthToken.Text = newSplit[1];
                            break;

                        case "oauth_token_secret":
                            lblAuthSecret.Text = newSplit[1];
                            break;
                            
                        case "user_nsid":
                            lblNsId.Text = newSplit[1];
                            break;
                    }
                }
            }
        }
    }
}
