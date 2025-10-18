using Application.Models;

namespace Application.UseCase.Place.GetPlace.Models;

public record GetPlaceListResponse
{
    public long Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public required string Address { get; init; }
}