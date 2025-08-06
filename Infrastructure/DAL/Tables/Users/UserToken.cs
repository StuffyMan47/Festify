using Infrastructure.DAL.BaseEntities;

namespace Infrastructure.DAL.Tables.Users;

public class UserToken : BaseEntity<long>
{
    public required string RefreshToken { get; init; }
    public required Guid UserId { get; init; }
    public DateTimeOffset ExpirationDate { get; init; }
}