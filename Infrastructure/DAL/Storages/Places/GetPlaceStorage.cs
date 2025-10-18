using Application.UseCase.Place.GetPlace.Interfaces;
using Application.UseCase.Place.GetPlace.Models;
using Infrastructure.DAL.DBContext;

namespace Infrastructure.DAL.Storages.Places;

public class GetPlaceStorage(AppDbContext dbContext) : IGetPlaceStorage
{
    public async Task<GetPlaceByIdResponse?> GetPlaceById(long placeId, CancellationToken cancellationToken)
    {
        return await dbContext.Places
            .Where(x=>x.Id == placeId)
            .Select(x=> new GetPlaceByIdResponse
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Longitude = x.Longitude,
                Address = x.Address,
                Width = x.Width
            }).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<List<GetPlaceListResponse>> GetPlaceList(GetPlaceListRequest request, CancellationToken cancellationToken)
    {
        var query = dbContext.Places
            .OrderByDescending(x => x.Id)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(request.Name))
        {
            query = query.Where(x => EF.Functions.ILike(x.Name, $"%{request.Name}%"));
        }
        
        return await query
            .Where(x => x.Id > request.Cursor)
            .Take(request.PageSize)
            .Select(x => new GetPlaceListResponse
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Address = x.Address,
            })
            .ToListAsync(cancellationToken);
    }
}