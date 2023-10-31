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
    public class CommentConfiguration : BaseConfiguration<Comment, int>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.UserID).IsRequired();
            builder.Property(c => c.EventID).IsRequired();
            builder.Property(c => c.CommentText).IsRequired();


            builder.HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(u => u.UserID)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Events)
                .WithMany(u => u.Comments)
                .HasForeignKey(x => x.EventID)
            .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
