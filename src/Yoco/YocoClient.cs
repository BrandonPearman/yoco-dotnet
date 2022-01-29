
using System;
using System.Net.Http;
using System.Text;

namespace Yoco
{
    public class YocoClient
    {
        private readonly HttpClient _httpClient;

        public YocoClient(HttpClient httpClient, string privateKey)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(
                Encoding.UTF8.GetBytes($"{privateKey}:")));
        }
    }
 
    

}

