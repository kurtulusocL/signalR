using Microsoft.AspNetCore.SignalR;
using SignalRServer.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServer.BusinessUI
{
    public class Business
    {
        readonly IHubContext<MyHub> _hubContext;
        public Business(IHubContext<MyHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task SendMessageAsync(string message)
        {
            await _hubContext.Clients.All.SendAsync("recieveMessage", message);
        }
    }
}
