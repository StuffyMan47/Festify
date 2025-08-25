using Application.UseCase.Event.CreateEvent.Interfaces;
using Application.UseCase.Event.CreateEvent.Models;
using Infrastructure.DAL.DBContext;
using Infrastructure.DAL.Tables;

namespace Infrastructure.DAL.Storages.Events;

public class CreateEventStorage(AppDbContext dbContext) : ICreateEventStorage
{
    public async Task CreateEvent(CreateEventRequest request, Guid userId)
    {
        dbContext.Events.Add(new Event()
        {
            Date = request.Date,
            Description = request.Description,
            PlaceId = request.PlaceId,
            UserId = userId,
            WelcomeSpeech = request.WelcomeSpeech,
            Newlyweds = request.Newlyweds,
        });
        
        await dbContext.SaveChangesAsync();
    }
}