using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

using System.Runtime.Serialization;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTime
{
    public static class HttpRequestHelper
    {
        /// <summary>
        /// Helper function to retrieve and deserialize a data object resource from a remove server via HTTP.
        /// </summary>
        /// <typeparam name="T">Type of the object to be retrieved.</typeparam>
        /// <param name="url">URL of the data object.</param>
        /// <returns>The retrieved object or null on error.</returns>
        public static T RequestObject<T>(string url) where T : class
        {
            try
            {
                // see: http://www.codeproject.com/Articles/6554/How-to-use-HttpWebRequest-and-HttpWebResponse-in-N
                // and: https://msdn.microsoft.com/en-us/library/system.net.httpwebrequest(v=vs.110).aspx
                // regarding the use of web requests
                HttpWebRequest request = WebRequest.CreateHttp(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) // automatically disposes of the response
                {
                    using (Stream content = response.GetResponseStream()) // automatically disposes of the content stream
                    {
                        // see: http://stackoverflow.com/questions/18242429/how-to-deserialize-json-data
                        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                        return (T)serializer.ReadObject(content);
                    }
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        /// <summary>
        /// Helper function to retrieve and deserialize an image resource from a remove server via HTTP.
        /// </summary>
        /// <param name="url">URL of the data object.</param>
        /// <returns>The retrieved image or null on error.</returns>
        public static Image RequestImage(string url)
        {
            try
            {
                // see: http://www.codeproject.com/Articles/6554/How-to-use-HttpWebRequest-and-HttpWebResponse-in-N
                // and: https://msdn.microsoft.com/en-us/library/system.net.httpwebrequest(v=vs.110).aspx
                // regarding the use of web requests
                HttpWebRequest request = WebRequest.CreateHttp(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) // automatically disposes of the response
                {
                    using (Stream content = response.GetResponseStream()) // automatically disposes of the content stream
                    {
                        // see: https://msdn.microsoft.com/en-us/library/1kcb3wy4(v=vs.110).aspx
                        // regarding reading an image from a stream
                        return Image.FromStream(response.GetResponseStream());
                    }
                }
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
