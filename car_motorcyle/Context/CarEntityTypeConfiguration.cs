using car_motorcyle.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace car_motorcyle.Context
{
    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Model).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Brand).IsRequired();
            builder.Property(x => x.LicensePlate);
            builder.Property(x => x.ProductionDate).IsRequired();
        }
    }
}
