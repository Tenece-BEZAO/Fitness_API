using Fitness.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.DAL.Configurations
{
    public class WorkOutConfiguration : IEntityTypeConfiguration<WorkOut>
    {
        public void Configure(EntityTypeBuilder<WorkOut> builder)
        {
            builder.Property(u => u.LiveWeight)
            .HasPrecision(18, 2);

            //SeedWorkOut(builder);
        }

        private void SeedWorkOut(EntityTypeBuilder<WorkOut> builder)
        {
            var workOut = new WorkOut 
            {
                 UniqueIdentifier = Guid.NewGuid(),
                 Id = 1,
                 //Name = "Aerobics",
                 CreatedAt = DateTime.Now,

            };

            var values = new List<WorkOut>() {workOut };
            builder.HasData(values);
        }
    }
}
