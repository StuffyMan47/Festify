using Application.Models;
using Application.Services.UserContext.Models;

namespace Application.Services.UserContext;

public interface IUserContextProvider
{
    UserContextModel GetUserContext(SystemRequestData? system = null);
}