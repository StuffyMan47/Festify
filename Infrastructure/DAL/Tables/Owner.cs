using Infrastructure.DAL.BaseEntities;
using Infrastructure.DAL.Tables.Users;

namespace Infrastructure.DAL.Tables;

public class Owner : BaseEntity<long>
{
    public required string OwnerName { get; init; }

    public List<Place>? Places { get; init; }
    public List<Event>? Events { get; init; }
    public List<User>? Users { get; init; }
}