using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Web;
using System.Windows.Forms;
using ServiceStack.Html;

namespace Wordpress.OAuthHandlers
{
    internal class FlickrOAuthHandler  : UserControl
    {

        // First stage - rquest a token
        //
        //  https://www.flickr.com/services/oauth/request_token
        //  ?oauth_nonce=89601180                                  # random string
        //  &oauth_timestamp=1305583298                            # # seconds since 01-Jan-1970
        //  &oauth_consumer_key=653e7a6ecc1d528c516cc8f92cf98611   # My app's key
        //  &oauth_signature_method=HMAC-SHA1
        //  &oauth_version=1.0
        //  &oauth_callback=http%3A%2F%2Fwww.example.com           # Callback?

        // The secret key is 

        private string RequestToken()
        {
            //var numSeconds = (int) (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds);

            //const string requestString = @"https://www.flickr.com/services/oauth/request_token";

            //// create the parameter string in alphabetical order
            //var parameters = "oauth_callback=" + UrlHelper.Encode("http://www.flickr.com");
            //parameters += "&oauth_consumer_key=" + tbClientID.Text;
            //parameters += "&oauth_nonce=" + "2340987";
            //parameters += "&oauth_signature_method=HMAC-SHA1";
            //parameters += "&oauth_timestamp=" + numSeconds;
            //parameters += "&oauth_version=1.0";

            //// Now build the full URL
            //var url = requestString + "?" 
            //    + parameters + "&oauth_signature=" 
            //    + generateSignature("GET", requestString, parameters, tbClientSecret.Text, string.Empty);

            //// Ask Flickr to give us the Token and the Token secret
            //var flickrResponse = new WebClient().DownloadString(url);

            var flickrResponse = "oauth_callback_confirmed=true&oauth_token=72157648405605070-e34cf2377bf5a721&oauth_token_secret=b12c821069b7cba3";
        
            // Now we want to extract the relevant information
            var split = flickrResponse.Split("&".ToCharArray());

            var okay = false;
            string token = null;
            string tokenSecret = null;

            foreach (var s in split)
            {
                var newSplit = s.Split("=".ToCharArray());

                switch (newSplit[0])
                {
                    case "oauth_callback_confirmed":
                        okay = bool.Parse(newSplit[1]);
                        break;

                    case "oauth_token":
                        token = newSplit[1];
                        break;

                    case "oauth_token_secret":
                        tokenSecret = newSplit[1];
                        break;
                }
            }

            // And we're done.
            return null;
        }



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

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
        }

        private void btnGotIt_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
