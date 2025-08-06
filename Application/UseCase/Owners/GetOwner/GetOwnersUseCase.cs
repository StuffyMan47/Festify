using Application.Errors;
using Application.Extensions.ActionResult;
using Application.UseCase.Owners.GetOwner.Interfaces;
using Application.UseCase.Owners.GetOwner.Models;

namespace Application.UseCase.Owners.GetOwner;

public class GetTenantsUseCase(IGetOwnersStorage storage)
{
    public async Task<Result<OwnerModel>> GetTenantById(int id)
    {
        var result = await storage.GetTenantById(id);

        return result == null
            ? ErrorProvider.Owners.NotFound(id).As<OwnerModel>()
            : Result<OwnerModel>.Success((OwnerModel)result);
    }

    public async Task<Result<OwnerModel>> GetTenantByName(string name)
    {
        var result = await storage.GetTenantByName(name);
        return result == null
            ? Result<OwnerModel>.Invalid().WithMessage($"Тенант с именем {name} не найден")
            : Result<OwnerModel>.Success((OwnerModel)result);
    }

    public async Task<Result<List<OwnerModel>>> GetTenantsList()
    {
        var result = await storage.GetTenants();
        return Result<List<OwnerModel>>.Success(result);
    }
}