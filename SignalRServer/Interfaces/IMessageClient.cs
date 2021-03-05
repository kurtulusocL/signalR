using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServer.Interfaces
{
    public interface IMessageClient
    {
        Task CLients(List<string> clients);
        Task NewUserJoined(string connectionId);
        Task OneUserLeaved(string connectionId);
    }
}
