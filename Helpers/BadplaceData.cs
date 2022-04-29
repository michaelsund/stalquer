using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using stalquer_server.Models;

namespace stalquer_server.Helpers
{
    public class BadPlaceData
    {
        public HttpClient Client { get; }

        public BadPlaceData(HttpClient client)
        {
            client.BaseAddress = new Uri("https://badplace.eu/");
            Client = client;
        }

        public async Task<IEnumerable<BadPlaceResponse>> GetBadplaceData()
        {
            return await Client.GetFromJsonAsync<IEnumerable<BadPlaceResponse>>(
              "/api/v2/serverbrowser/busy");
        }
    }
}