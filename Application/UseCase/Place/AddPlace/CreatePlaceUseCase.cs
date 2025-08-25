using Application.Extensions.ActionResult;
using Application.UseCase.Place.AddPlace.Interfaces;
using Application.UseCase.Place.AddPlace.Models;

namespace Application.UseCase.Place.AddPlace;

public class CreatePlaceUseCase(ICreatePlaceStorage storage)
{
    public async Task<Result<long>> CreatePlace(CreatePlaceRequest request)
    {
        var result = await storage.CreatePlace(request);
        return Result<long>.Success(result);
    }
}

