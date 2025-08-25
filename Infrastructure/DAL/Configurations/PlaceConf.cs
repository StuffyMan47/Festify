using Infrastructure.DAL.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DAL.Configurations;

public class PlaceConf: IEntityTypeConfiguration<Place>
{
    public void Configure(EntityTypeBuilder<Place> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.Events).WithOne(x => x.Place).HasForeignKey(x => x.PlaceId);
    }
}