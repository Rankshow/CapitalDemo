using System.Text.Json.Serialization;

namespace CapitalDemo.Domain.Models;

public class Common
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("dateCreatedBy")]
    public DateTime DateCreated { get; set; }
    [JsonPropertyName("dateCreatedBy")]
    public DateTime DateModified { get; set; }
    [JsonPropertyName("CreatedBy")]
    public string CreatedBy { get; set; }
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set;}
}
