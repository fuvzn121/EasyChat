using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EasyChat.Hubs {
    [HubName("Echo")]
    public class EchoHub : Hub {
        public void Hello() {
            Clients.All.hello();
        }
        public void Send(String text) {
            Clients.All.Receive(text);
        }
    }
}