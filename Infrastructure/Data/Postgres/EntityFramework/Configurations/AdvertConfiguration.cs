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
    public class AdvertConfiguration : BaseConfiguration<Advert, int>
    {
        public override void Configure(EntityTypeBuilder<Advert> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.AdvertText).IsRequired();

            builder.HasOne(a => a.User)
                .WithMany(u => u.Adverts)
                .HasForeignKey(a => a.UserID)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(a => a.Sport)
                .WithMany(s => s.Adverts)
                .HasForeignKey(a => a.SportID)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(a => a.Adress)
                .WithMany(ad => ad.Adverts)
                .HasForeignKey(a => a.AdressID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(a => a.Offers)
                .WithOne(o => o.Advert)
                .HasForeignKey(o => o.AdvertID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
