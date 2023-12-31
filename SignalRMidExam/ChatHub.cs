﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalRMidExam
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.BroadcastMessage(name, message);
        }

        public void ShareFile(string name, string fileName, string fileData)
        {
            Clients.All.BroadcastFile(name, fileName, fileData);
        }
    }
}