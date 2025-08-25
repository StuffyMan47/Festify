namespace Application.UseCase.Place.AddPlace.Models;

public record CreatePlaceRequest(string Name, string Description, string Address, string? Url, double? Width, double? Longitude);