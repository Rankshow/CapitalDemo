using Newtonsoft.Json;


namespace CapitalDemo.Domain.Models;

public class Candidate
{
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("firstName")]
    public string FirstName { get; set; }
    [JsonProperty("candidateId")]
    public string CandidateId { get; set; }
    [JsonProperty("lastName")]
    public string LastName { get; set; }
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("phone")]
    public string Phone { get; set; }
    [JsonProperty("nationality")]
    public string Nationality { get; set; }
    [JsonProperty("currentResidence")]
    public string CurrentResidence { get; set; }
    [JsonProperty("idNumber")]
    public double IDNumber { get; set; }
    [JsonProperty("dateOfBirth")]
    public DateTime DateOfBirth { get; set; }
    [JsonProperty("gender")]
    public string Gender {  get; set; }
    public ICollection<Employer> Employers { get; set; }
}
