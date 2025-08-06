namespace Application.UseCase.Owners.GetOwner.Models;

public record struct OwnerModel(int Id, string Name, int? AgentId);
