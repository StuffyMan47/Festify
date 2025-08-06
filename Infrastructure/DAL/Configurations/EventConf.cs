using Infrastructure.DAL.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DAL.Configurations;

public class EventConf : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasOne(x => x.User).WithMany().HasForeignKey(x=>x.UserId);
        builder.HasOne(x=>x.Photo).WithMany().HasForeignKey(x=>x.PhotoId);
    }
}