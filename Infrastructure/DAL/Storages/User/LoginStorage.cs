using Application.UseCase.User.Login.Interfaces;
using Application.UseCase.User.Login.Models;
using Infrastructure.DAL.DBContext;
using Infrastructure.DAL.Extensions.User;

namespace Infrastructure.DAL.Storages.User;

public class LoginStorage(AppDbContext dbContext) : ILoginStorage
{
    public async Task<UserModel?> GetUser(string login)
    {
        return await (from user in dbContext.Users.IgnoreQueryFilters().GetByLogin(login)
                      select new UserModel
                      {
                          UserId = user.Id,
                          SystemRole = user.SystemRole,
                          Login = user.Login,
                          PasswordHash = user.PasswordHash,
                          PasswordSalt = user.PasswordSalt
                      }).FirstOrDefaultAsync();
    }
}