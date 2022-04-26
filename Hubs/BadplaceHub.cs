using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace stalquer_server.Hubs
{
    public class BadplaceHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}