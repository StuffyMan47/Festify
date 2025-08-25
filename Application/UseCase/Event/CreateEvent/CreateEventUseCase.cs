using Application.Extensions.ActionResult;
using Application.Services.UserContext;
using Application.UseCase.Event.CreateEvent.Interfaces;
using Application.UseCase.Event.CreateEvent.Models;

namespace Application.UseCase.Event.CreateEvent;

public class CreateEventUseCase(ICreateEventStorage storage, IUserContextProvider userProvider)
{
    public async Task<Result> CreateEvent(CreateEventRequest request)
    {
        var currentUser = userProvider.GetUserContext();
        await storage.CreateEvent(request, currentUser.Id);

        return Result.Success();
    }
}
