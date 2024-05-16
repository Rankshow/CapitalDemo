namespace CapitalDemo.Domain.Models;

public class Employer : Common
{
    public string Paragraph { get; set; }
    public string YearOfGraduation { get; set; }
    public string[] MultipleChoice { get; set; }
    public bool YesOrNo {  get; set; }
    public int YearsOfExperience { get; set; }
    public DateOnly YearMovedToUk { get; set; }
}
