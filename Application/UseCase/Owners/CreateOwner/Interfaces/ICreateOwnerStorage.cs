using Application.Interfaces;
using Application.UseCase.Owners.CreateOwner.Models;

namespace Application.UseCase.Owners.CreateOwner.Interfaces;

public interface ICreateOwnerStorage : IScopedService
{
    Task<int> CreateTenant(CreateTenantRequest request);
}