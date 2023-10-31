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
    public class EventsConfiguration : BaseConfiguration<Events, int>
    {
        public override void Configure(EntityTypeBuilder<Events> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.EventName).IsRequired();
            builder.Property(e => e.EventDate).IsRequired();
            builder.Property(e => e.SportID).IsRequired();
            builder.Property(e => e.AdressID).IsRequired();


            builder.HasOne(e => e.Sports)
                   .WithMany(s => s.Events)
                   .HasForeignKey(e => e.SportID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.UserEvents)
          .WithOne(ue => ue.Events)
          .HasForeignKey(ue => ue.EventID);

            builder.HasOne(e => e.Adress)
                   .WithMany(a => a.Events)
                   .HasForeignKey(e => e.AdressID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.Points)
                   .WithOne(p => p.Events)
                   .HasForeignKey(p => p.EventID);

        }
    }
}
