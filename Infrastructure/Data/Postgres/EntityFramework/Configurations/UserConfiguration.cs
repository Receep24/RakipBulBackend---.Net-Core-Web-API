using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : BaseConfiguration<User,int>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
         base.Configure(builder);
        builder.Property(u => u.Email).IsRequired();
        builder.Property(u => u.UserName).IsRequired();
        builder.Property(u => u.FirstName).IsRequired();
        builder.Property(u => u.LastName).IsRequired();
        builder.Property(u => u.Age).IsRequired();
        builder.Property(u => u.PasswordSalt).IsRequired();
        builder.Property(u => u.PasswordHash).IsRequired();
        builder.Property(u => u.UserType).IsRequired();
        builder.Property(u => u.Gender).IsRequired();
        builder.Property(u => u.UserImage);


        builder.HasMany(u => u.UserEvents)
             .WithOne(ue => ue.User)
             .HasForeignKey(ue => ue.UserID);

        builder.HasMany(u => u.Points)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Comments)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserID)
            .OnDelete(DeleteBehavior.Cascade);


        builder.HasMany(u => u.Adverts)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Offers)
            .WithOne(o => o.User)
            .HasForeignKey(o => o.UserID)
            .OnDelete(DeleteBehavior.Cascade);


    }
}