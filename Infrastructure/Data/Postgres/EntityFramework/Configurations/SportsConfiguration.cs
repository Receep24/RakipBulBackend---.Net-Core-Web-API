using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class SportsConfiguration:BaseConfiguration<Sports,int>
    {
        public override void Configure(EntityTypeBuilder<Sports> builder)
        {
            base.Configure(builder);
            builder.Property(s => s.SportName)          
          .IsRequired(); 

            
            builder.Property(s => s.SportImage)
                   .HasMaxLength(255);
            
            builder.HasMany(s => s.Events)
                   .WithOne(e => e.Sports)
                   .HasForeignKey(e => e.SportID)
                   .OnDelete(DeleteBehavior.Restrict);
          
            builder.HasMany(s => s.Adverts)
                   .WithOne(a => a.Sport)
                   .HasForeignKey(a => a.SportID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
