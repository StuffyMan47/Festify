using Infrastructure.DAL.Tables;
using Infrastructure.DAL.Tables.Users;

namespace Infrastructure.DAL.DBContext;

public partial class AppDbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Event> Events => Set<Event>();
    public DbSet<Guest> Guests => Set<Guest>();
    public DbSet<Image> Photos => Set<Image>();
    public DbSet<Place> Places => Set<Place>();
    public DbSet<Schedule> Schedules => Set<Schedule>();
    public DbSet<Owner> Owners => Set<Owner>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();
}