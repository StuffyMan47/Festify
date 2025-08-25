using Application.UseCase.Place.AddPlace.Interfaces;
using Application.UseCase.Place.AddPlace.Models;
using Infrastructure.DAL.DBContext;
using Infrastructure.DAL.Tables;

namespace Infrastructure.DAL.Storages.Places;

public class CreatePlaceStorage(AppDbContext dbContext) : ICreatePlaceStorage
{
    public async Task<long> CreatePlace(CreatePlaceRequest request)
    {
        var place = new Place
        {
            Name = request.Name,
            Description = request.Description,
            Address = request.Address,
            Url = request.Url,
            Width = request.Width,
            Longitude = request.Longitude
        };
        dbContext.Places.Add(place);
        
        await dbContext.SaveChangesAsync();
        return place.Id;
    }
}