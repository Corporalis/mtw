using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MumsTheWord.Web.Services
{
    public class ApiClient : IApiClient
    {
        public async Task<Places> GetServicesAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://maps.googleapis.com");
                var result =  await client.GetAsync("/maps/api/place/nearbysearch/json?location=-33.8670,151.1957&radius=500&types=food&name=cruise&key=AIzaSyAjG_9M9j2dSrBrPZjIvU865aakDPGcsq8").ConfigureAwait(false);
                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Places>(content, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                // TODO - Send HTTP requests
            }
        }
    }
}