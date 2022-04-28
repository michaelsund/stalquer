using System;
using System.Collections.Generic;

namespace stalquer_server.Models
{
    public class Player
    {
        public int Ping { get; set; }
        public bool Spec { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int Frags { get; set; }
    }
}