using LJS.GroupBetLogger.Mobile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Reactive.Linq;
using Akavache;
using System.Threading.Tasks;

namespace LJS.GroupBetLogger.Mobile.Services
{
    public static class TokenService
    {
        public static async Task<Token> GetTokenAsync()
        {
            try
            {
                return await BlobCache.Secure.GetObject<Token>("token");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void GetToken(string userName, string password)
        {
            var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", userName),
                    new KeyValuePair<string, string>("Password", password)
                };
            var content = new FormUrlEncodedContent(pairs);

            UriBuilder builder = new UriBuilder($"{AppSettings.ApiEndPoint}token");
            var url = builder.ToString();

            Token token;

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, content).Result;
                token = JsonConvert.DeserializeObject<Token>(response.Content.ReadAsStringAsync().Result);
            }

            BlobCache.Secure.InsertObject("token", token);
        }
    }
}
