using CapitalDemo.Domain.Models;
using CapitalDemo.Service.Contracts.Dtos;
using CapitalDemo.Service.Contracts.Request;

namespace CapitalDemo.Service.Contracts.Extension;

public static class EmployerExtension
{
    public static Employer AsEntity(this CreateEmployerReq req)
    {
        return new Employer
        {
            Paragraph = req.Paragraph,
            YesOrNo = req.YesOrNo,
            YearMovedToUk = req.YearMovedToUk.Date,
            YearOfGraduation = req.YearOfGraduation.ToString(),
            YearsOfExperience = req.YearsOfExperience,
            MultipleChoice = req.MultipleChoice
        };
    }

    public static EmployerDto AsDto(this UpdateEmployerReq req)
    {
        return new EmployerDto
        {
            Id = req.Id,
            CandidateId = req.CandidateId,
            EmployerId = req.EmployerId,
            MultipleChoice = req.MultipleChoice,
            YearOfGraduation = req.YearOfGraduation,
            YearsOfExperience = req.YearsOfExperience,
            
        }
    }
}
