using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SimpleChat.Shared.Models;

namespace SimpleChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(MessagePack messagePack)
        {
            await Clients.All.SendAsync("ReceiveMessage", messagePack);
        }
    }
}
