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
    public class UserGoalConfiguration : IEntityTypeConfiguration<UserGoal>
    {
        public void Configure(EntityTypeBuilder<UserGoal> builder)
        {
            builder.Property(u => u.TargetWeight)
            .HasPrecision(18, 2);
        }
    }
}
