namespace Application.UseCase.Place.GetPlace.Models;

public record GetPlaceByIdResponse
{
    public long Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public required string Address {  get; init; }
    public double? Width { get; init; }
    public double? Longitude { get; init; }
}