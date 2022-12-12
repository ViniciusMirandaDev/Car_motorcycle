using car_motorcyle.Entities;
using Microsoft.EntityFrameworkCore;

namespace car_motorcyle.Context
{
    public class CoreContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new CarEntityTypeConfiguration());
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
        }
    }
}
