using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Entities.Base;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
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
    public class AdressConfiguration : BaseConfiguration<Adress, int>
    {
        public override void Configure(EntityTypeBuilder<Adress> builder)
        {
            base.Configure(builder);
            builder.Property(a => a.AdressName).IsRequired();
            builder.Property(a => a.CityId).IsRequired();
            builder.Property(a => a.DistrictId).IsRequired();


            builder.HasOne(a => a.City)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.District)
                .WithMany(d => d.Addresses)
                .HasForeignKey(a => a.DistrictId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(a => a.Events)
                .WithOne(e => e.Adress)
                .HasForeignKey(e => e.AdressID);

            builder.HasMany(a => a.Adverts)
                .WithOne(ad => ad.Adress)
                .HasForeignKey(ad => ad.AdressID);
        }
    }
}
