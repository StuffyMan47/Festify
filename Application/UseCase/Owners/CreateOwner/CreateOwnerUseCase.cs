using Application.Extensions.ActionResult;
using Application.UseCase.Owners.CreateOwner.Interfaces;
using Application.UseCase.Owners.CreateOwner.Models;

namespace Application.UseCase.Owners.CreateOwner;

public class CreateOwnerUseCase(ICreateOwnerStorage storage)
{
    public async Task<Result<int>> CreateTenant(CreateTenantRequest request)
    {
        var result = await storage.CreateTenant(request);

        return Result<int>.Success(result);
    }
}