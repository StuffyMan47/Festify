using Infrastructure.DAL.BaseEntities;
using Infrastructure.DAL.Tables.Users;

namespace Infrastructure.DAL.Tables;

public class Event : BaseEntity<long>
{
    public DateTime Date { get; init; }
    public string? WelcomeSpeech { get; init; }
    public string? Description { get; init; }
    public string? Newlyweds { get; init; }
    public required long PlaceId { get; init; }
    public required Guid UserId { get; init; }

    public long PhotoId {  get; init; }
    public Image? Photo {  get; init; }
    public List<Schedule> Schedule { get; init; } = [];
    public List<Guest> Guests { get; init; } = [];
    public Place? Place { get; init; }
    public User? User { get; init; }
}