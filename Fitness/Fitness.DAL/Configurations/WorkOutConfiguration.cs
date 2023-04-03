using Fitness.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL.Configurations
{
    public class WorkOutConfiguration : IEntityTypeConfiguration<WorkOut>
    {
        public void Configure(EntityTypeBuilder<WorkOut> builder)
        {
            builder.Property(u => u.LiveWeight)
            .HasPrecision(18, 2);
        }
    }
}
