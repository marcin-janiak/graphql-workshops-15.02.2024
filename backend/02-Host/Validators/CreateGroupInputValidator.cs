using _02_Host.GraphQL.Groups;
using FluentValidation;

namespace _02_Host.Validators;

public class CreateGroupInputValidator : AbstractValidator<GroupsMutationExtensions.CreateGroupInput>
{
    public CreateGroupInputValidator()
    {
        RuleFor(x => x.Name).MinimumLength(1);
    }
}