using System.Text.Json.Serialization;

namespace CapitalDemo.Domain.Models;

public class Employer : Common
{
    [JsonPropertyName("paragraph")]
    public string Paragraph { get; set; }
    [JsonPropertyName("yearOfGraduation")]
    public string YearOfGraduation { get; set; }
    [JsonPropertyName("multipleChoice")]
    public string[] MultipleChoice { get; set; }
    [JsonPropertyName("yesOrNo")]
    public bool YesOrNo {  get; set; }
    [JsonPropertyName("yearOfExperience")]
    public int YearsOfExperience { get; set; }
    [JsonPropertyName("yearMovedToUk")]
    public DateOnly YearMovedToUk { get; set; }
}
