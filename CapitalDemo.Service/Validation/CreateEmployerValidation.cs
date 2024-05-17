using CapitalDemo.Service.Contracts.Request;
using FluentValidation;

namespace CapitalDemo.Service.Validation;

public class CreateEmployerValidation : AbstractValidator<CreateEmployerReq>
{
    public CreateEmployerValidation()
    {
        RuleFor(s => s.Paragraph)
            .NotEmpty()
            .NotNull()
            .MinimumLength(500)
            .WithMessage("Paragraph must be at least 500 characters long.");

        RuleFor(s => s.MultipleChoice)
            .NotEmpty()
            .NotNull()
            .WithMessage("MultipleChoice is required");

        RuleFor(s => s.YearsOfExperience)
            .NotEmpty()
            .NotNull()
            .WithMessage("YearsOfExperience is required");

        RuleFor(s => s.YearOfGraduation)
            .NotEmpty()
            .NotNull()
            .WithMessage("YearOfGraduation is required");

        RuleFor(s => s.YearMovedToUk.Year)
            .NotEmpty()
            .NotNull()
            .WithMessage("MoveToUk is required");
    }
}
