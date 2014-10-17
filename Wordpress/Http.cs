using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using ServiceStack.Text;

namespace Wordpress
{

    public class Http
    {
        #region Empty Request Data
        private class EmptyRequestData
        { }
        #endregion Empty Request Data

        #region runQueryAndParse

        // Helper functions
        //
        public static void RunQueryAndParse<T>(
            string url, 
            string authorization,
            object requestData, 
            string method, 
            out T response, 
            bool readResponse = true)
        {
            var request = WebRequest.Create(url) as HttpWebRequest;

            // Set the parameters for the request
            if (!string.IsNullOrEmpty(authorization))
            {
                request.Headers["Authorization"] = authorization;
            }

            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Method = method;
            request.Timeout = 120000;

            // This is a rather strange hack - the Microsoft HttpWebRequest seems to have
            // timeouts and generate 400 errors if a PUT request is made and there is no
            // data on the request.  So if we are a PUT, and we were passed in NULL as our
            // request data, create an empty request data object, and use that on the request.
            if (("PUT" == method) && (null == requestData))
            {
                requestData = new EmptyRequestData();
            }


            // Serialize any request data we saw
            if (null != requestData)
            {
                // Add the serialized version of the JSON object to the request
                using (var swriter = new StreamWriter(request.GetRequestStream()))
                {
                    var serialiser = new JavaScriptSerializer();
                    var jsonObject = serialiser.Serialize(requestData);
                    swriter.Write(jsonObject);
                }
            }

            try
            {
                using (var webResponse = (HttpWebResponse)request.GetResponse())
                {
                    if (readResponse)
                    {
                        string responseString;
                        using (var data = webResponse.GetResponseStream())
                        {
                            using (var reader = new StreamReader(data))
                            {
                                responseString = reader.ReadToEnd();
                            }
                        }

                        // Now deserialise
                        response = JsonSerializer.DeserializeFromString<T>(responseString);
                    }
                    else
                    {
                        response = default(T);
                    }
                }
            }
            catch (WebException e)
            {
                using (var webResponse = e.Response)
                {
                    var httpResponse = (HttpWebResponse)webResponse;
                    string errorText = null;

                    using (var data = webResponse.GetResponseStream())
                    {
                        if (null != data)
                        {
                            using (var reader = new StreamReader(data))
                            {
                                errorText = reader.ReadToEnd();
                            }
                        }
                    }

                    // Create an exception that contains the information we need
                    //
                    throw new ApplicationException(string.Format(CultureInfo.InvariantCulture,
                        "Error Code: {0}\rMessage  : {1}",
                        httpResponse.StatusCode, errorText));
                }
            }
        }
        #endregion runQueryAndParse
    }
}
