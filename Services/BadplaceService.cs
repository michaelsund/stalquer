using System;
using System.Net.WebSockets;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stalquer_server.Hubs;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SignalR;
using System.Net.Http;
using stalquer_server.Helpers;
using stalquer_server.Models;

namespace stalquer_server.Services
{
    public class BadplaceService : IHostedService
    {
        JsonSerializerOptions serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        private readonly IHubContext<BadplaceHub> _hub;

        // The singleton store for use with controllers
        private IBadplaceResponseList _badplaceResponseList;
        private readonly BadPlaceData _badplaceData;

        public IEnumerable<BadPlaceResponse> LatestResponse { get; set; }

        private Timer _timer;
        public BadplaceService(IHubContext<BadplaceHub> hub, BadPlaceData badPlaceData, IBadplaceResponseList badplaceResponseList)
        {
            _hub = hub;
            _badplaceData = badPlaceData;
            _badplaceResponseList = badplaceResponseList;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(GetAndPushData, null, 0, 60000);
            return Task.CompletedTask;
        }
        async void GetAndPushData(object state)
        {
            System.Console.WriteLine("Fetching data and broadcasting!");
            try
            {
                LatestResponse = await _badplaceData.GetBadplaceData();

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Error fetching from badplace.");
            }

            // Convert IEnumerable to List and remove ServeMe player
            List<BadPlaceResponse> convertedResponse = LatestResponse.ToList();
            for (int x = 0; x < convertedResponse.Count; x++)
            {
                for (int y = 0; y < convertedResponse[x].Players.Count; y++)
                {
                    if (convertedResponse[x].Players[y].Name.Contains("ServeMe")) {
                        convertedResponse[x].Players.RemoveAt(y);
                    }
                }
            }

            // Update the singleton store.
            _badplaceResponseList.BadplaceResponses = convertedResponse;
            // Broadcast to signalr clients
            await _hub.Clients.All.SendAsync("Update", JsonSerializer.Serialize(convertedResponse, serializeOptions));
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            //New Timer does not have a stop. 
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }
    }
}