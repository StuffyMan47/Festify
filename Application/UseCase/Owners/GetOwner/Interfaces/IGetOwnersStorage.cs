using Application.Interfaces;
using Application.UseCase.Owners.GetOwner.Models;

namespace Application.UseCase.Owners.GetOwner.Interfaces;

public interface IGetOwnersStorage : IScopedService
{
    Task<OwnerModel?> GetTenantById(int id);
    Task<OwnerModel?> GetTenantByName(string name);
    Task<OwnerModel?> GetTenantByInn(string inn, string kpp);
    Task<List<OwnerModel>> GetTenants();
}