using System;
using System.Net.WebSockets;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stalquer_server.Hubs;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SignalR;
using stalquer_server.Helpers;
using stalquer_server.Models;

namespace stalquer_server.Services
{
    public class BadplaceService : IHostedService
    {
        private readonly IHubContext<BadplaceHub> _hub;
        private readonly BadPlaceData _badplaceData;

        public IEnumerable<BadPlaceResponse> LatestResponse { get; private set; }

        private Timer _timer;
        public BadplaceService(IHubContext<BadplaceHub> hub, BadPlaceData badPlaceData)
        {
            _hub = hub;
            _badplaceData = badPlaceData;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(GetAndPushData, null, 0, 60000);
            return Task.CompletedTask;
        }
        async void GetAndPushData(object state)
        {
            System.Console.WriteLine("Fetching data and broadcasting!");
            LatestResponse = await _badplaceData.GetBadplaceData();
            // try
            // {
            //     LatestResponse = await _badplaceData.GetBadplaceData();
            // }
            // catch (HttpRequestException)
            // {
            //     GetIssuesError = true;
            //     LatestIssues = Array.Empty<GitHubIssue>();
            // }
            await _hub.Clients.All.SendAsync("ReceiveMessage", "AM I GLOBAL DADDY?!?!?!?!?");
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            //New Timer does not have a stop. 
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }
    }
}