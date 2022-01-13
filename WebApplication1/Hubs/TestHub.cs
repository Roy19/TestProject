﻿using Microsoft.AspNetCore.SignalR;

namespace WebApplication1.Hubs
{
    public class TestHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
