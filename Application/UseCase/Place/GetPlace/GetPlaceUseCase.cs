using Application.Extensions.ActionResult;
using Application.UseCase.Place.GetPlace.Interfaces;
using Application.UseCase.Place.GetPlace.Models;

namespace Application.UseCase.Place.GetPlace;

public class GetPlaceUseCase(IGetPlaceStorage storage)
{
    public async Task<Result<GetPlaceByIdResponse>> GetPlaceById(long placeId, CancellationToken cancellationToken)
    {
        var result = await storage.GetPlaceById(placeId, cancellationToken);

        if (result is null)
        {
            return Result<GetPlaceByIdResponse>.Invalid().WithMessage("Площадка не найдена");
        }
        return Result<GetPlaceByIdResponse>.Success(result);
    }

    public async Task<Result<List<GetPlaceListResponse>>> GetPlaceList(GetPlaceListRequest request, CancellationToken cancellationToken)
    {
        var result = await storage.GetPlaceList(request, cancellationToken);
        long newCursor = result.Count > 0 ? result.Max(x => x.Id) : request.Cursor;

        return Result<List<GetPlaceListResponse>>.Success(result).WithCursor(newCursor);
    }
}
