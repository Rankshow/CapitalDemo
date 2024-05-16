using System.Text.Json.Serialization;

namespace CapitalDemo.Domain.Models;

public class Candidate : Common
{
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("phone")]
    public string Phone { get; set; }
    [JsonPropertyName("nationality")]
    public string Nationality { get; set; }
    [JsonPropertyName("currentResidence")]
    public string CurrentResidence { get; set; }
    [JsonPropertyName("idNumber")]
    public double IDNumber { get; set; }
    [JsonPropertyName("dateOfBirth")]
    public DateOnly DateOfBirth { get; set; }
    [JsonPropertyName("gender")]
    public string Gender {  get; set; }
    public ICollection<Employer> Employers { get; set; }
}
