using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class CitiesConfiguration : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            

            builder.HasKey(x => x.CityId);
            builder.Property(x => x.CityId).ValueGeneratedOnAdd();
            builder.Property(x => x.CityName).IsRequired();

            builder.HasMany(x => x.Addresses)
                .WithOne(x => x.City)
                .HasForeignKey(x=>x.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Districts)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
