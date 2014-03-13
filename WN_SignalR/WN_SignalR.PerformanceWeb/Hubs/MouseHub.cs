using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using WN_SignalR.PerformanceWeb.Models;

namespace WN_SignalR.PerformanceWeb.Hubs
{
    public class MouseHub : Hub
    {
        public void Move(MouseMoveCoordinates movement)
        {
            Clients.Others.RegisterMovement(movement);
        }
    }
}