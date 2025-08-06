using Infrastructure.DAL.BaseEntities;
using Application.Enums;

namespace Infrastructure.DAL.Tables;

public class Guest : BaseEntity<Guid>
{
    public required string Name { get; init; }
    public bool? IsCome { get; init; }
    public bool? NeedTransfer {  get; init; }
    public string? CoupleName { get; init; }
    public required long EventId { get; init; }
    public List<AlcoholType> Alcohol { get; init; } = [];
    public GuestType MessageType { get; init; }

    public Event? Event { get; set; }
}