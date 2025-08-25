using Application.Interfaces;
using Application.UseCase.Place.AddPlace.Models;

namespace Application.UseCase.Place.AddPlace.Interfaces;

public interface ICreatePlaceStorage : IScopedService
{
    Task<long> CreatePlace(CreatePlaceRequest request);
}