using System;
using System.Collections.Generic;

namespace stalquer_server.Models
{
    public class BadPlaceResponse
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string Map { get; set; }
        public bool QtvOnly { get; set; }
        public List<Player> Players { get; set; }
    }
}