using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRonMVC4.Hubs
{
    public class HellowWorldHub : Hub
    {
        public void Enter(String name)
        {
            Clients.Caller.getName(HttpUtility.HtmlEncode(name));
        }
        public void Send(String name,String msg) {
            Clients.All.getMessage(name, HttpUtility.HtmlEncode(msg));
        }
    }
}