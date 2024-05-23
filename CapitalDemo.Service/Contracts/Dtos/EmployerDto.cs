using CapitalDemo.Repository.Enum;

namespace CapitalDemo.Service.Contracts.Dtos
{
    public class EmployerDto
    {
        public string Id { get; set; }
        public string CandidateId { get; set; }
        public string EmployerId { get; set; }
        public string Paragraph { get; set; }
        public YearOfGraduationEnum YearOfGraduation { get; set; }
        public string[] MultipleChoice { get; set; }
        public bool YesOrNo { get; set; }
        public string YearsOfExperience { get; set; }
        public DateTime YearMovedToUk { get; set; }
    }
}
