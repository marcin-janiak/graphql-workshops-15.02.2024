using _01_PersonalizationApi.GraphQL;
using FluentValidation;

namespace _01_PersonalizationApi.FluentValidation;

public class CreateGroupInputValidator : AbstractValidator<CreateGroupInput>
{
    public CreateGroupInputValidator()
    {
        RuleFor(x => x.Name).Must(x => !x.Contains("_")).WithMessage("Not contain _ character");
    }
}
public class CreateGroupBestWithFairyBreadValidator : AbstractValidator<CreateGroupBestWithFairyBreadInput>
{
    public CreateGroupBestWithFairyBreadValidator()
    {
        RuleFor(x => x.Name).Must(x => !x.Contains("_")).WithMessage("Not contain _ character");
    }
}
