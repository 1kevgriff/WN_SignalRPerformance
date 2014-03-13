using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WN_SignalR.PerformanceWeb.Models
{
    public class MouseMoveCoordinates
    {
        [JsonProperty("x")]
        public string XCoordinate { get; set; }
        [JsonProperty("y")]
        public string YCoordinate { get; set; }
    }
}