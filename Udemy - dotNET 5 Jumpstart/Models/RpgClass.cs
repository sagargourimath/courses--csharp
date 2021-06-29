using System.Text.Json.Serialization;

namespace Udemy___dotNET_5_Jumpstart.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Healer
    }
}