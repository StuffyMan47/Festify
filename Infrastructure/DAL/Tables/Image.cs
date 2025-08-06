using Infrastructure.DAL.BaseEntities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.DAL.Tables;

public class Image : BaseEntity<long>
{
    public required string FileName { get; init; }

    public long EventId { get; init; }
    public Event? Event { get; init; }
}