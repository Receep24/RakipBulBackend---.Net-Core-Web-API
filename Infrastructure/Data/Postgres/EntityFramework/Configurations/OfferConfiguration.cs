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
    public class OfferConfiguration:BaseConfiguration<Offer,int>
    {
        public override void Configure(EntityTypeBuilder<Offer> builder)
        {
            base.Configure(builder);
            builder.Property(o => o.OfferText)
                   .HasMaxLength(255);

            builder.HasOne(o => o.Advert)
                   .WithMany(a => a.Offers)
                   .HasForeignKey(o => o.AdvertID)
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(o => o.User)
                   .WithMany(u => u.Offers)
                   .HasForeignKey(o => o.UserID)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
