using Application.Interfaces;
using Application.UseCase.Event.CreateEvent.Models;

namespace Application.UseCase.Event.CreateEvent.Interfaces;

public interface ICreateEventStorage : IScopedService
{
    Task CreateEvent(CreateEventRequest request, Guid userId);
}
