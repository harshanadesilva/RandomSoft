using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using ApiProject.Models;

namespace ApiProject.Controllers
{
    /// <summary>
    /// A generic wrapper class to REST API calls
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class HTTPClientWrapper<T> where T : class
    {
        /// <summary>
        /// For getting the resources from a web api
        /// </summary>
        /// <param name="url">API Url</param>
        /// <returns>A Task with result object of type T</returns>
        public static async Task<T> Get(string url)
        {
            T result = null;
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(new Uri(url)).Result;

                response.EnsureSuccessStatusCode();
                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    if (x.IsFaulted)
                        throw x.Exception;

                    result = JsonConvert.DeserializeObject<T>(x.Result);
                });
            }

            return result;
        }
    }

    public class PostController : ApiController
    {
        //// GET: api/Post
        //public IEnumerable<Post> Get()
        //{
        //    return new Post ;
        //}

        // GET: api/Post/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Post
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Post/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Post/5
        public void Delete(int id)
        {
        }
    }
}
