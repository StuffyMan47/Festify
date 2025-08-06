using Infrastructure.DAL.Tables.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DAL.Configurations;

public class UserTokenConfig : IEntityTypeConfiguration<UserToken>
{
    public void Configure(EntityTypeBuilder<UserToken> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne<User>().WithMany(x => x.UserTokens).HasForeignKey(x => x.UserId);
    }
}