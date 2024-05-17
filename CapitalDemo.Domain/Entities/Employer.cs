using Newtonsoft.Json;
namespace CapitalDemo.Domain.Models;

public class Employer
{
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("candidateId")]
    public string CandidateId { get; set; }
    [JsonProperty("employerId")]
    public string EmployerId { get; set; }
    [JsonProperty("paragraph")]
    public string Paragraph { get; set; }
    [JsonProperty("yearOfGraduation")]
    public string YearOfGraduation { get; set; }
    [JsonProperty("multipleChoice")]
    public string[] MultipleChoice { get; set; }
    [JsonProperty("yesOrNo")]
    public bool YesOrNo {  get; set; }
    [JsonProperty("yearOfExperience")]
    public int YearsOfExperience { get; set; }
    [JsonProperty("yearMovedToUk")]
    public DateTime YearMovedToUk { get; set; }
}
