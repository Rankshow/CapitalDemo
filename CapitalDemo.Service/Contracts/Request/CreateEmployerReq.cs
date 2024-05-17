using CapitalDemo.Repository.Enum;

namespace CapitalDemo.Service.Contracts.Request;

public class CreateEmployerReq
{
    public string? CandidateId { get; set; }
    public string? EmployerId { get; set; }
    public string? Paragraph { get; set; }
    public YearOfGraduationEnum YearOfGraduation { get; set; }
    public string[]? MultipleChoice { get; set; }
    public bool YesOrNo { get; set; }
    public int YearsOfExperience { get; set; }
    public DateTime YearMovedToUk { get; set; }
}
