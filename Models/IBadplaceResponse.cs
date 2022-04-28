using System;
using System.Collections.Generic;

namespace stalquer_server.Models
{
    public interface IBadPlaceResponse
    {
        public string Title { get; set; }
        public int MaxClients { get; set; }
        public int MaxSpectators { get; set; }
        public string IpAddress { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string Map { get; set; }
        public bool QtvOnly { get; set; }
        public List<Player> Players { get; set; }
        public Settings Settings { get; set; }
    }
}