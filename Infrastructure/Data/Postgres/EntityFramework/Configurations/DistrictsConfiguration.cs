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
    public class DistrictsConfiguration : IEntityTypeConfiguration<Districts>
    {
        public void Configure(EntityTypeBuilder<Districts> builder)
        {
            builder.HasKey(d => d.DistrictId);
            builder.Property(d => d.DistrictId).ValueGeneratedOnAdd();
            builder.Property(d => d.DistrictName);                  

            builder.HasOne(d => d.City)
                   .WithMany(c => c.Districts)
                   .HasForeignKey(d => d.CityId)
                   .OnDelete(DeleteBehavior.Restrict); 

            builder.HasMany(d => d.Addresses)
                   .WithOne(a => a.District)
                   .HasForeignKey(a => a.DistrictId);
        }
    }
}
