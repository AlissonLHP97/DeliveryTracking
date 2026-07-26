using System.Text.Json.Serialization;

namespace DeliveryTracking.Models.Base
{
    public class Entity
    {
        [JsonPropertyOrder(-1)]
        public long Id { get; set; }
    }
}
