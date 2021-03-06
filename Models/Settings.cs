using System.Text.Json.Serialization;

namespace stalquer_server.Models
{
    public class Settings
    {
        public string Status { get; set; }
        public string Hostname { get; set; }
        public int Timelimit { get; set; }
        [JsonPropertyName("*version")]
        public string Version { get; set; }
        public int Deathmatch { get; set; }
        public string Teamplay { get; set; }
    }
}