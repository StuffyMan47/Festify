using Application.Interfaces;
using Application.UseCase.Place.GetPlace.Models;

namespace Application.UseCase.Place.GetPlace.Interfaces;

public interface IGetPlaceStorage : IScopedService
{
    Task<List<GetPlaceListResponse>> GetPlaceList(GetPlaceListRequest request, CancellationToken cancellationToken);
    Task<GetPlaceByIdResponse?> GetPlaceById(long placeId, CancellationToken cancellationToken);
}