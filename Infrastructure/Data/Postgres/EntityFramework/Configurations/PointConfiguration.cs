using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class PointConfiguration : BaseConfiguration<Point, int>
    {
        public override void Configure(EntityTypeBuilder<Point> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Points)
                   .IsRequired();


            builder.HasOne(p => p.User)
                   .WithMany(u => u.Points)
                   .HasForeignKey(p => p.UserID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Events)
                   .WithMany(e => e.Points)
                   .HasForeignKey(p => p.EventID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
