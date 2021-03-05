using Microsoft.AspNetCore.SignalR;
using SignalRServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServer.Hubs
{
    public class MyHub : Hub<IMessageClient>
    {
        static List<string> clients = new List<string>();

        public override async Task OnConnectedAsync()
        {
            clients.Add(Context.ConnectionId);
            await Clients.All.CLients(clients);
            await Clients.All.NewUserJoined(Context.ConnectionId);
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            clients.Remove(Context.ConnectionId);
            await Clients.All.CLients(clients);
            await Clients.All.OneUserLeaved(Context.ConnectionId);
        }
    }
}
