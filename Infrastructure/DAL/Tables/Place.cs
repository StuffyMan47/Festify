using Infrastructure.DAL.BaseEntities;

namespace Infrastructure.DAL.Tables;

public class Place : BaseEntity<long>
{
    public required string Name { get; init; }
    public string? Url { get; init; }
    public required string Address {  get; init; }
    public double? Width { get; init; }
    public double? Longitude { get; init; }

    public List<Event> Events { get; init; } = [];
}