using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class ContactConfiguration : BaseConfiguration<Contact,int>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {     
            base.Configure(builder);
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.PhoneNumber).IsRequired();

            builder.HasOne(c => c.User)
                .WithOne(u => u.Contact)
                .HasForeignKey<Contact>(c => c.UserID)
                .IsRequired();
        }
    }
}
