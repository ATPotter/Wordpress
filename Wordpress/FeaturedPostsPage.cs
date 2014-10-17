using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using ServiceStack.ServiceClient.Web;
using ServiceStack.Text;
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
            Cursor = Cursors.WaitCursor;

            // Okay, so we want to get a list of all posts
            var client = new JsonServiceClient(
                string.Format(CultureInfo.InvariantCulture,
                    "https://public-api.wordpress.com/rest/v1/sites/{0}",
                    WpSite));

            var postInfo = client.Get<Posts>("/posts?fields=found&number=1");
            lblNumEntries.Text = postInfo.found.ToString(CultureInfo.InvariantCulture);
            progressBar.Maximum = postInfo.found;
            progressBar.Minimum = 0;
            progressBar.Step = 1;

            var postsDownloaded = 0;
            var pageNumber = 0;


            while (postsDownloaded < postInfo.found)
            {
                // Go for the next page (it's a 1-based index)
                ++pageNumber;

                // Get a page of data
                var thisPage = GetPosts(client, pageNumber, 5);

                // Log it to the listview
                if (null != thisPage)
                {
                    foreach (var post in thisPage.posts)
                    {
                        var statusUpdate = "No action needed";

                        lvDisplay.Items.Add(new ListViewItem( new[] {
                                post.ID.ToString(CultureInfo.InvariantCulture),
                                post.featured_image,
                                post.title,
                                string.Empty,
                                string.Empty
                            }));
                        lvDisplay.Items[lvDisplay.Items.Count - 1].EnsureVisible();
                        Application.DoEvents();


                        if (string.IsNullOrEmpty(post.featured_image))
                        {
                            lvDisplay.Items[lvDisplay.Items.Count - 1].SubItems[4].Text = "Updating";
                            lvDisplay.Items[lvDisplay.Items.Count - 1].EnsureVisible();
                            Application.DoEvents();

                            var imageFile = GetImageFileName(post);
                            statusUpdate = UpdateFeaturedImage(post, imageFile, 5);
                        }

                        // Marks the success on the page
                        progressBar.PerformStep();
                        lvDisplay.Items[lvDisplay.Items.Count - 1].SubItems[4].Text = statusUpdate;
                        lvDisplay.Items[lvDisplay.Items.Count - 1].EnsureVisible();
                        Application.DoEvents();

                    }

                    // Count the number of posts we've added, and 
                    postsDownloaded += thisPage.posts.Count;
                }
            }
        }


        private static Posts GetPosts(ServiceClientBase client, int pageNumber, int maxRetries)
        {
            client.Timeout = new TimeSpan(0, 0, 2, 0);

            // Get the URI for the query
            var requestUri = string.Format(CultureInfo.InvariantCulture, "/posts?number=20&page={0}", pageNumber);

            // And try to get the data
            var currentAttemptNumber = 0;
            while (currentAttemptNumber < maxRetries)
            {
                try
                {
                    // Try to get the data, return on success
                    var thisPage = client.Get<Posts>(requestUri);
                    Application.DoEvents();
                    return thisPage;
                }
                catch (Exception)
                {
                    // Ignore the exception try again
                    ++currentAttemptNumber;
                }
            }
            
            // No, it hasn't worked - give up
            return null;
        }


        private string GetImageFileName(Post post)
        {
            var retVal = GetUrl(post.content);

            if (string.IsNullOrEmpty(retVal))
            {
                retVal = GetUrl2(post.content);
            }

            return retVal;
        }

        private string UpdateFeaturedImage(Post post, string imageFile, int maxRetries)
        {
            string retVal;

            var uri = string.Format(CultureInfo.InvariantCulture,
                "https://public-api.wordpress.com/rest/v1/sites/{0}/posts/{1}",
                WpSite, post.ID);

            // Update the featured image, leave everything else unchanged
            // Make up to five attempts to post
            var newPost = new PostOnlyFeatured{featured_image = imageFile};

            var numberOfAttempts = 0;

            while (true)
            {
                ++numberOfAttempts;

                try
                {
                    // Try to post, break out of the loop if it works
                    Post response;
                    Http.RunQueryAndParse(uri, "Bearer " + Authorization, newPost, "POST", out response);
                    retVal = "Successfully updated";
                    break;
                }
                catch (Exception ex)
                {
                    if (numberOfAttempts == maxRetries)
                    {
                        retVal = "Failed to update";
                        break;
                    }
                }
            }

            // All done
            return retVal;
        }



        //// we need to try to get the image url.
        //                // parse the content field
        //                var imageFile = 




        //                // If the post has no featured item, edit the post
        //                if (string.IsNullOrEmpty(post.featured_image))
        //                {
        //                    if (!string.IsNullOrEmpty(imageFile))
        //                    {

        //                        // Update the featured image, leave everything else unchanged
        //                        // Make up to five attempts to post
        //                        var newPost = new PostOnlyFeatured
        //                        {
        //                            featured_image = imageFile
        //                        };

        //                        var numberOfAttempts = 0;

        //                        while (numberOfAttempts < 5)
        //                        {
        //                            try
        //                            {
        //                                // Try to post, break out of the loop if it works
        //                                Post response;
        //                                Http.RunQueryAndParse(uri, "Bearer " + Authorization, newPost, "POST",
        //                                    out response);
        //                                lvStatus = "Successfully updated";
        //                                break;
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                ++numberOfAttempts;

        //                                if (numberOfAttempts == 4)
        //                                {
        //                                    throw new ApplicationException(
        //                                        "Failed after five attempts", ex);
        //                                }
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        // Couldn't get info for link
        //                        lvStatus = "Couldn't parse file name";
        //                    }
        //                }

        //            }
        //            catch (WebServiceException ex)
        //            {
        //                MessageBox.Show(ex.ErrorMessage);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.ToString());
        //            }

        //        }

        //        // Count the number of posts we've added, and 
        //        postsDownloaded += thisPage.posts.Count;
        //    }
        //}

        private static string GetUrl(string attachment)
        {
            string retVal = null;
            try
            {
                // Get rid of the outer parts of the string
                var split = attachment.Split("{".ToCharArray());
                var toParse = split[2].Substring(0, split[2].Length - 2);
                var secondSplit = toParse.Split(",".ToCharArray());

                foreach (var s in secondSplit)
                {
                    var colonPosition = s.IndexOf(":");
                    var leftSide = s.Substring(0, colonPosition);

                    if ("URL" == leftSide)
                    {
                        retVal = s.Substring(colonPosition + 1);
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }

            return retVal;
        }

        private static string GetUrl2(string content)
        {
            string retVal = null;

            try
            {
                // Find the first "http"
                var httpPosition = content.IndexOf("http");

                var shortened = content.Substring(httpPosition);

                // strip everything after and including the "
                var quotePosition = shortened.IndexOf("\"");
                var url = shortened.Substring(0, quotePosition);

                retVal = url;
            }
            catch (Exception)
            {
            }

            return retVal;
        }
    }
}
