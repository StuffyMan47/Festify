using Infrastructure.DAL.BaseEntities;

namespace Infrastructure.DAL.Tables;

public class Schedule : BaseEntity<long>
{
    public required string Name { get; init; }
    public TimeOnly Time { get; init; }

    public Event? Event { get; init; }
}