using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.DAL.Extensions.User;

public static class Extensions
{
    [SuppressMessage("Performance", "CA1862:Use the \'StringComparison\' method overloads to perform case-insensitive string comparisons")]
    [SuppressMessage("ReSharper", "SpecifyStringComparison")]
    public static IQueryable<Tables.Users.User> GetByLogin(this IQueryable<Tables.Users.User> query, string login) =>
    query.Where(x => x.Login.ToLower() == login.ToLower());
}
