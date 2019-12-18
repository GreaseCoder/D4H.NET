using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using D4H.NET.Models;
using Newtonsoft.Json;

namespace D4H.NET
{
    public class APIClient : IAPIClient
    {
        private readonly HttpClient client;

        public APIClient(string token)
        {
            client = new HttpClient() { BaseAddress = new Uri("https://api.d4h.org/v2/") };
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }

        public async Task<APIResponse<T>> GETRequest<T>(string path, Dictionary<string, object> headers)
            where T : IModel
        {
            var request = new HttpRequestMessage(HttpMethod.Get, path);
            headers.AsParallel().ForAll(x => request.Headers.Add(x.Key, x.Value.ToString()));

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<APIResponse<T>>(responseStream);
            }
            else
            {
                throw new APIClientException(response);
            }
        }
        
    }
}
