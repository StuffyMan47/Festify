namespace Application.Models;

public record SystemRequestData(Guid UserId = default, int? OwnerId = null);
