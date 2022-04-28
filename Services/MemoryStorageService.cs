using System;
using System.Net.WebSockets;
using System.Text;
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
    public class MemoryStorageService : IHostedService
    {
        public IEnumerable<BadPlaceResponse> LatestResponse { get; set; }
    }
}