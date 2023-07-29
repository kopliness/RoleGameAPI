using System.Text.Json.Serialization;

namespace RoleGameAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight=1,
        Mage=2,
        Rogue=3,
        Orc=4
    }
}