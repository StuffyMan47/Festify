namespace Application.UseCase.Owners.CreateOwner.Models;

public record struct CreateTenantRequest(string Name, bool? IsMultiHub = false);

public class CreateTenantRequestValidator : AbstractValidator<CreateTenantRequest>
{
    public CreateTenantRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithName("Название организации").MaximumLength(150);
    }
}